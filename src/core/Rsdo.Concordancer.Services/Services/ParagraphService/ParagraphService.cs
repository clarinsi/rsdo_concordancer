using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.ServiceModel.Shared;
using Rsdo.Concordancer.Services.Framework.DbContext;
using Rsdo.Concordancer.Services.Services.PartOfSpeechService;

namespace Rsdo.Concordancer.Services.Services.ParagraphService;

public class ParagraphService : IParagraphService
{
    private readonly CorpusDbContext dbContext;
    private readonly IPartOfSpeechService partOfSpeechService;

    public ParagraphService(CorpusDbContext dbContext, IPartOfSpeechService partOfSpeechService)
    {
        this.dbContext = dbContext;
        this.partOfSpeechService = partOfSpeechService;
    }

    public async Task<Token> GetToken(Guid tokenId)
    {
        return await dbContext.Token.Include(t => t.Sentence).ThenInclude(s => s.Paragraph).SingleAsync(t => t.Id == tokenId);
    }

    public async Task<List<ConcordanceToken>> GetTokens(Expression<Func<Token, bool>> predicate)
    {
        var tokens = await dbContext.Token.Include(t => t.Sentence)
            .ThenInclude(s => s.Paragraph)
            .Where(predicate)
            .OrderBy(t => t.Sentence.RecordOrder)
            .ThenBy(t => t.RecordOrder)
            .ToListAsync();

        var concordanceTokens = new List<ConcordanceToken>();

        foreach (var token in tokens)
        {
            concordanceTokens.Add(
                new ConcordanceToken()
                {
                    Form = token.Form,
                    Lemma = token.Lemma,
                    Msd = token.Msd,
                    MsdDescription = await partOfSpeechService.GetMsdDescriptionByCode(token.Msd),
                    TokenOrder = token.TokenOrder,
                    Type = token.Type,
                });
        }

        return concordanceTokens;
    }
}