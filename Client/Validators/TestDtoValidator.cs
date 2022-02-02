using Client.Models;
using FluentValidation;

namespace Client.Validators;

public class TestDtoValidator : AbstractValidator<TestDto>
{
    public TestDtoValidator()
    {
        RuleForEach(x => x.Messages)
            .NotEmpty();

        RuleFor(x => x.Messages)
            .Must(x => x.Count >= 5);
    }
}