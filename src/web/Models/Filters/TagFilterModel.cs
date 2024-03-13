namespace MyPersonalBlog.Models.Filters;

public class TagFilterModel
{
    public IEnumerable<string> TagsParaRemover { get; set; }
        = Enumerable.Empty<string>();
}