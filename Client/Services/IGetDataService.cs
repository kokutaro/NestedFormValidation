using Client.Models;

namespace Client.Services;

public interface IGetDataService
{
    Task<List<AddressDto>> GetDataAsync(GetDataRequest request);
}