namespace Client.Models;

public class PersonDto
{
    public string? PersonName { get; set; }
    
    public AddressDto AddressDto { get; set; } = new();
    public TestDto TestDto { get; set; } = new();
}