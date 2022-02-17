using Client.Models;

namespace Client.Services;

public class DataValidatorMockService : IDataValidatorService
{
    public Dictionary<string, List<string>> GetValidationMessages()
    {
        return new Dictionary<string, List<string>>
        {
            [nameof(PersonDto.PersonName)] = new()
            {
                "Server side validation error"
            },
            ["AddressDto.AddressLine1"] = new()
            {
                "SA"
            },
            ["TestDto.Messages"] = new()
            {
                "Test Dto"
            }
        };
    }
}