using OpenSearch.Client;
using Rsdo.Concordancer.Core.Model;
using Rsdo.Concordancer.Infrastructure.Search.Indexes;
using Rsdo.Concordancer.Infrastructure.Search.Model;

namespace Rsdo.Concordancer.Infrastructure.Search.AddRecordsHandlers;

public class AddConcordanceRecordsHandler : BaseAddRecordsHandler<Concordance, EsConcordance>
{
    public AddConcordanceRecordsHandler(IOpenSearchClient client, IIndexProviderFactory indexProviderFactory)
        : base(client, indexProviderFactory)
    {
    }

    protected override EsConcordance ConvertEntity(Concordance entity)
    {
        return new EsConcordance
        {
            Id = entity.Token.Id,
            TextId = entity.TextId,
            Token = ConvertToken(entity.Token),
            TokenLeft1 = ConvertToken(entity.TokenLeft1),
            TokenLeft2 = ConvertToken(entity.TokenLeft2),
            TokenLeft3 = ConvertToken(entity.TokenLeft3),
            TokenLeft4 = ConvertToken(entity.TokenLeft4),
            TokenLeft5 = ConvertToken(entity.TokenLeft5),
            TokenLeft6 = ConvertToken(entity.TokenLeft6),
            TokenLeft7 = ConvertToken(entity.TokenLeft7),
            TokenLeft8 = ConvertToken(entity.TokenLeft8),
            TokenLeft9 = ConvertToken(entity.TokenLeft9),
            TokenLeft10 = ConvertToken(entity.TokenLeft10),
            TokenRight1 = ConvertToken(entity.TokenRight1),
            TokenRight2 = ConvertToken(entity.TokenRight2),
            TokenRight3 = ConvertToken(entity.TokenRight3),
            TokenRight4 = ConvertToken(entity.TokenRight4),
            TokenRight5 = ConvertToken(entity.TokenRight5),
            TokenRight6 = ConvertToken(entity.TokenRight6),
            TokenRight7 = ConvertToken(entity.TokenRight7),
            TokenRight8 = ConvertToken(entity.TokenRight8),
            TokenRight9 = ConvertToken(entity.TokenRight9),
            TokenRight10 = ConvertToken(entity.TokenRight10),
        };
    }

    private static EsToken ConvertToken(Rsdo.Concordancer.Core.Entities.Token token)
    {
        if (token == null)
        {
            return null;
        }

        return new EsToken
        {
            Form = token.Form,
            FormLower = token.Form?.ToLower(),
            Lemma = token.Lemma,
            LemmaLower = token.Lemma?.ToLower(),
            Msd = token.Msd,
        };
    }
}