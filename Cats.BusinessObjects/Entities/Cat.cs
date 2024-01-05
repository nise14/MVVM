namespace Cats.BusinessObjects.Entities;

public class Cat
{
    public string Id { get; set; } = null!;
    public string Url { get; set; } = null!;
    public int Width { get; set; }
    public int Height { get; set; }
}