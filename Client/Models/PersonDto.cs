namespace Client.Models;

public class PersonDto
{
    public string? PersonName { get; set; }
    public string? UserCode { get; set; }

    public AddressDto AddressDto { get; set; } = new();
    public TestDto TestDto { get; set; } = new();

    public static IEnumerable<PersonDto> GetMockData()
    {
        yield return new PersonDto
        {
            PersonName = "平沢 唯",
            UserCode = "281300"
        };
        yield return new PersonDto
        {
            PersonName = "秋山 澪",
            UserCode = "281301"
        };
        yield return new PersonDto
        {
            PersonName = "田井中 律",
            UserCode = "281302"
        };
        yield return new PersonDto
        {
            PersonName = "琴吹 紬",
            UserCode = "281303"
        };
        yield return new PersonDto
        {
            PersonName = "中野 梓",
            UserCode = "281304"
        };
    }
}