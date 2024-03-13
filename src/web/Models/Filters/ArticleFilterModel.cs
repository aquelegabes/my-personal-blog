namespace MyPersonalBlog.Models.Filters;

public class ArticleFilterModel
{
    public ICollection<string> Tags { get; set; } =
        Enumerable.Empty<string>().ToList();

    public string Titulo { get; set; }
        = string.Empty;
}