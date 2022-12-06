using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.ServiceModel.Shared;

namespace Rsdo.Concordancer.Services.Services.ParagraphService;

public interface IParagraphService
{
    Task<Token> GetToken(Guid tokenId);

    Task<List<ConcordanceToken>> GetTokens(Expression<Func<Token, bool>> predicate);
}