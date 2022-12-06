using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.ServiceModel.Requests.Concordances;

public abstract class SearchedWord
{
    public string Form { get; set; }

    public FormSearchType FormSearchType { get; set; }

    public string Lemma { get; set; }
}