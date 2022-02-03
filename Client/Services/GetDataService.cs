using Client.Models;

namespace Client.Services;

public class GetDataService : IGetDataService
{

    public async Task<List<AddressDto>> GetDataAsync(GetDataRequest request)
    {
        await Task.Delay(500);
        return Enumerable.Range(1, 10)
            .Select(x => new AddressDto
            {
                AddressLine1 = $"Data {x}",
                AddressLine2 = request.Status.ToString()
            }).ToList();
    }
}