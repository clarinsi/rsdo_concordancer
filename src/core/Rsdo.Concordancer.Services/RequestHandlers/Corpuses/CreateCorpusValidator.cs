using FluentValidation;
using Rsdo.Concordancer.ServiceModel.Requests.Corpuses;

namespace Rsdo.Concordancer.Services.RequestHandlers.Corpuses;

public class CreateCorpusValidator : AbstractValidator<CreateCorpus>
{
    public CreateCorpusValidator()
    {
        RuleFor(x => x.Title).NotEmpty();
    }
}