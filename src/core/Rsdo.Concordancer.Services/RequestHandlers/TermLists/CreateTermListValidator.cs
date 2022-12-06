using FluentValidation;
using Rsdo.Concordancer.ServiceModel.Requests.TermLists;

namespace Rsdo.Concordancer.Services.RequestHandlers.TermLists;

public class CreateTermListValidator : AbstractValidator<CreateTermList>
{
    public CreateTermListValidator()
    {
        RuleFor(x => x.SourceFile).NotEmpty();
    }
}