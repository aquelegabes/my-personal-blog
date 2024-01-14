namespace MyPersonalBlog.Models;

public class TagModel
{
    public TagModel() { }
    public TagModel(string name)
    {
        Name = name;
    }
    
    public string Name { get; set; } = string.Empty;
    public string Href => $"/articles?tags={this.Name}";
}