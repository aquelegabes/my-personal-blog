namespace MyPersonalBlog.Entities;

public class Tag
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string HexColor { get; set; } = string.Empty;
}