using FluentValidation;
using Rsdo.Concordancer.ServiceModel.Requests.Texts;

namespace Rsdo.Concordancer.Services.RequestHandlers.Texts;

public class CreateTextValidator : AbstractValidator<CreateText>
{
    public CreateTextValidator()
    {
        RuleFor(x => x.SourceFile).NotEmpty();
    }
}