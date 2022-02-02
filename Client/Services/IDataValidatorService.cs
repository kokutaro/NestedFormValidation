namespace Client.Services;

public interface IDataValidatorService
{
    Dictionary<string, List<string>> GetValidationMessages();
}