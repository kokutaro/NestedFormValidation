using Client.Models;
using FluentValidation;

namespace Client.Validators;

public class PersonDtoValidator : AbstractValidator<PersonDto>
{
    public PersonDtoValidator()
    {
        RuleFor(x => x.PersonName)
            .NotEmpty();

        RuleFor(x => x.AddressDto)
            .SetValidator(new AddressDtoValidator());

        RuleFor(x => x.TestDto)
            .SetValidator(new TestDtoValidator());
    }
}