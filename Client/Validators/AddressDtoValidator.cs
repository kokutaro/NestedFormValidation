using Client.Models;
using FluentValidation;

namespace Client.Validators;

public class AddressDtoValidator : AbstractValidator<AddressDto>
{
    public AddressDtoValidator()
    {
        RuleFor(x => x.AddressLine1)
            .NotEmpty();

        RuleFor(x => x.AddressLine2)
            .NotEmpty();
    }
}