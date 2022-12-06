using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Core.Exceptions;
using Rsdo.Concordancer.Core.Extensions;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.Texts;
using Rsdo.Concordancer.ServiceModel.Shared;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Framework.BulkLoaders;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.RequestHandlers.Texts;

public class ImportTextHandler : IRequestHandler<ImportText, ExecutionResult>
{
    private readonly CorpusDbContext dbContext;
    private readonly IBulkLoader bulkLoader;
    private readonly IServiceBus serviceBus;

    public ImportTextHandler(CorpusDbContext dbContext, IBulkLoader bulkLoader, IServiceBus serviceBus)
    {
        this.dbContext = dbContext;
        this.bulkLoader = bulkLoader;
        this.serviceBus = serviceBus;
    }

    public async Task<ExecutionResult> Handle(ImportText request, CancellationToken cancellationToken)
    {
        // Get text
        // Dont track text since the data is imported with bulk loading and that would cause duplicate entities to be inserted
        var text = await dbContext.Text.AsNoTracking().SingleOrDefaultAsync(t => t.Id == request.TextId, cancellationToken);
        if (text == null)
        {
            throw new XNotFoundException(Errors.NotFound.EntityNotFound(EntityType.Text, request.TextId));
        }

        // Check if file exists
        if (!File.Exists(text.SourceFile))
        {
            throw new FileNotFoundException(Errors.NotFound.FileNotFound(text.SourceFile), text.SourceFile);
        }

        try
        {
            // Change status to importing
            await ChangeStatus(text, ImportStatus.Importing, cancellationToken);

            // Import text
            await ImportText(text);

            // Bulk load data into database
            await SaveTextWithBulkLoading(text, cancellationToken);

            // Send job to index text
            await serviceBus.Send(
                new IndexText()
                {
                    CorpusId = request.CorpusId,
                    TextId = text.Id,
                });

            // Change status to importing completed
            await ChangeStatus(text, ImportStatus.ImportingCompleted, cancellationToken);

            return new ExecutionResult();
        }
        catch (Exception)
        {
            await ChangeStatus(text, ImportStatus.ImportingFaulted, cancellationToken);
            throw;
        }
    }

    private static async Task ImportText(Text text)
    {
        await using var stream = new FileStream(text.SourceFile, FileMode.Open, FileAccess.Read);
        using (var streamReader = new StreamReader(stream))
        {
            string line;
            var paragraphOrder = 0;
            var sentenceOrder = 0;
            var tokenOrder = 0;
            var paragraphTokenOrder = 0;
            Paragraph paragraph = null;
            Sentence sentence = null;

            while ((line = await streamReader.ReadLineAsync()) != null)
            {
                if (line.StartsWith("# newpar", StringComparison.OrdinalIgnoreCase))
                {
                    // New paragraph
                    paragraph = new Paragraph()
                    {
                        RecordOrder = ++paragraphOrder,
                        TextAutoId = text.AutoId,
                    }.ApplyCreateValues();
                    text.Paragraphs ??= new List<Paragraph>();
                    text.Paragraphs.Add(paragraph);

                    // Reset sentence order and order of tokens in paragraph
                    sentenceOrder = 0;
                    paragraphTokenOrder = 0;
                }
                else if (line.StartsWith("# sent", StringComparison.OrdinalIgnoreCase))
                {
                    // New sentence
                    sentence = new Sentence()
                    {
                        RecordOrder = ++sentenceOrder,
                    }.ApplyCreateValues();
                    paragraph.Sentences ??= new List<Sentence>();
                    paragraph.Sentences.Add(sentence);

                    // Reset token order
                    tokenOrder = 0;
                }
                else if (!line.StartsWith("#") && !string.IsNullOrWhiteSpace(line))
                {
                    // New token
                    var data = line.Split('\t');
                    var token = new Token()
                    {
                        RecordOrder = ++tokenOrder,
                        TokenOrder = ++paragraphTokenOrder,
                        Form = data[1],
                        Lemma = data[2],
                        Type = data[3].Equals("PUNCT", StringComparison.OrdinalIgnoreCase) ? TokenType.PunctuationCharacter : TokenType.Word,
                        Msd = data[4],
                    }.ApplyCreateValues();
                    sentence.Tokens ??= new List<Token>();
                    sentence.Tokens.Add(token);

                    // Check if there should be a space after token
                    if (!data[9].Contains("SpaceAfter=No", StringComparison.OrdinalIgnoreCase))
                    {
                        token = new Token()
                        {
                            RecordOrder = ++tokenOrder,
                            TokenOrder = ++paragraphTokenOrder,
                            Form = " ",
                            Type = TokenType.Character,
                        }.ApplyCreateValues();
                        sentence.Tokens.Add(token);
                    }
                }
            }
        }
    }

    private async Task SaveTextWithBulkLoading(Text text, CancellationToken cancellationToken)
    {
        var paragraphs = text.Paragraphs;
        await bulkLoader.InsertEntities(paragraphs, cancellationToken);
        paragraphs.ForEach(p => p.Sentences.ForEach(s => s.ParagraphAutoId = p.AutoId));

        var sentences = paragraphs.SelectMany(p => p.Sentences).ToList();
        await bulkLoader.InsertEntities(sentences, cancellationToken);
        sentences.ForEach(s => s.Tokens.ForEach(t => t.SentenceAutoId = s.AutoId));

        var tokens = sentences.SelectMany(s => s.Tokens).ToList();
        await bulkLoader.InsertEntities(tokens, false, cancellationToken);
    }

    private async Task ChangeStatus(Text text, ImportStatus newStatus, CancellationToken cancellationToken)
    {
        text.Status = newStatus;
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}