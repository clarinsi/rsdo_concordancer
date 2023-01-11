using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Core.Exceptions;
using Rsdo.Concordancer.Core.Extensions;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.Core.Model;
using Rsdo.Concordancer.Core.Search;
using Rsdo.Concordancer.ServiceModel.Requests.Texts;
using Rsdo.Concordancer.ServiceModel.Shared;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.RequestHandlers.Texts;

public class IndexTextHandler : IRequestHandler<IndexText, ExecutionResult>
{
    private readonly CorpusDbContext dbContext;
    private readonly ISearchEngine searchEngine;

    public IndexTextHandler(CorpusDbContext dbContext, ISearchEngine searchEngine)
    {
        this.dbContext = dbContext;
        this.searchEngine = searchEngine;
    }

    public async Task<ExecutionResult> Handle(IndexText request, CancellationToken cancellationToken)
    {
        // Get text
        var text = await dbContext.Text.SingleOrDefaultAsync(t => t.Id == request.TextId, cancellationToken);
        if (text == null)
        {
            throw new XNotFoundException(Errors.NotFound.EntityNotFound(EntityType.Text, request.TextId));
        }

        try
        {
            // Change status to indexing
            await ChangeStatus(text, ImportStatus.Indexing, cancellationToken);

            // Index text
            await IndexText(text, cancellationToken);

            // Change status to indexing completed and active
            await ChangeStatus(text, ImportStatus.IndexingCompleted, cancellationToken);
            await ChangeStatus(text, ImportStatus.Active, cancellationToken);

            return new ExecutionResult();
        }
        catch (Exception)
        {
            await ChangeStatus(text, ImportStatus.IndexingFaulted, cancellationToken);
            throw;
        }
    }

    public async Task IndexText(Text text, CancellationToken cancellationToken)
    {
        // Get paragraphs
        var paragraphs = await dbContext.Paragraph.Where(p => p.TextAutoId == text.AutoId).OrderBy(p => p.RecordOrder).ToListAsync(cancellationToken);

        // Index each paragraph individually
        foreach (var paragraph in paragraphs)
        {
            await IndexParagraph(text, paragraph, cancellationToken);
        }

        // Commit indexed concordances
        await searchEngine.Commit();
    }

    public async Task IndexParagraph(Text text, Paragraph paragraph, CancellationToken cancellationToken)
    {
        // Get tokens (skip spaces)
        var tokens = await dbContext.Token.Include(t => t.Sentence)
            .Where(t => t.Sentence.ParagraphAutoId == paragraph.AutoId && t.Type != TokenType.Character)
            .OrderBy(t => t.TokenOrder)
            .ToListAsync(cancellationToken);

        // Get concordances
        var concordances = GetConcordances(text, paragraph, tokens);

        // Add concordances to search engine
        await searchEngine.Add(concordances);
    }

    private static List<Concordance> GetConcordances(Text text, Paragraph paragraph, List<Token> tokens)
    {
        var concordances = new List<Concordance>();
        for (var i = 0; i < tokens.Count; i++)
        {
            var concordance = new Concordance()
            {
                ParagraphId = paragraph.Id,
                TextId = text.Id,
            };

            // set center token
            concordance.SetToken(tokens[i], 0);

            // set left and right context tokens
            for (var c = 1; c <= 10; c++)
            {
                // left context
                if (i - c >= 0)
                {
                    concordance.SetToken(tokens[i - c], -c);
                }

                // right context
                if (i + c < tokens.Count)
                {
                    concordance.SetToken(tokens[i + c], c);
                }
            }

            concordances.Add(concordance);
        }

        return concordances;
    }

    private async Task ChangeStatus(Text text, ImportStatus newStatus, CancellationToken cancellationToken)
    {
        text.Status = newStatus;
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}