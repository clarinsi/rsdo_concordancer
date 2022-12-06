using System;
using OpenSearch.Client;
using Rsdo.Concordancer.Infrastructure.Search.Indexes;
using Rsdo.Concordancer.Infrastructure.Search.Model;
using Term = Rsdo.Concordancer.Core.Entities.Term;

namespace Rsdo.Concordancer.Infrastructure.Search.AddRecordsHandlers;

public class AddTermRecordsHandler : BaseAddRecordsHandler<Term, EsTerm>
{
    public AddTermRecordsHandler(IOpenSearchClient client, IIndexProviderFactory indexProviderFactory)
        : base(client, indexProviderFactory)
    {
    }

    protected override EsTerm ConvertEntity(Term entity)
    {
        // Tokenize form, lemma and msd
        var forms = entity.Form.Split(' ');
        var lemmas = entity.Lemma.Split(' ');
        var msds = entity.Msd.Split(' ');

        return new EsTerm
        {
            Id = entity.Id,
            Frequency = entity.Frequency,
            Token = GetToken(0),
            TokenRight1 = GetToken(1),
            TokenRight2 = GetToken(2),
            TokenRight3 = GetToken(3),
            TokenRight4 = GetToken(4),
            Weight = entity.Weight,
        };

        EsToken GetToken(int index)
        {
            if (index > forms.Length)
            {
                return null;
            }

            return new EsToken()
            {
                Form = GetValue(forms, index),
                Lemma = GetValue(lemmas, index),
                Msd = GetValue(msds, index),
                FormLower = GetValue(forms, index)?.ToLower(),
                LemmaLower = GetValue(lemmas, index)?.ToLower(),
            };
        }

        string GetValue(string[] values, int index)
        {
            return index < values.Length ? values[index] : null;
        }
    }
}