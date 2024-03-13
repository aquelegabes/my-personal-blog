namespace MyPersonalBlog.Models;

public class TagModel
{
    public TagModel() { }
    public TagModel(string name)
    {
        Nome = name;
    }

    public string Nome { get; set; } = string.Empty;
}