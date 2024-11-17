using System.Net;
using System.Text.Json.Serialization;
namespace HomeWork6._2;

public class Book
{
    //[JsonIgnore] -- при додаванні цього рядка серіалізатор буде ігнорувати властивість
    public int PublishingHouseId { get; set; }
    //[JsonPropertyName("Name")] -- при додаванні цього рядка серіалізатор буде вважати, що ця властивість має назву "Name"
    public string Title { get; set; }
    public PublishingHouse PublishingHouse { get; set; }
    public Book(int publishingHouseId, string title, PublishingHouse publishingHouse)
    {
        PublishingHouseId = publishingHouseId;
        Title = title;
        PublishingHouse = publishingHouse;
    }
}

public class PublishingHouse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public PublishingHouse(int id, string name, string address)
    {
        Id = id;
        Name = name;
        Address = address;
    }
}
