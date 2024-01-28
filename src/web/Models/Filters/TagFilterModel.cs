namespace MyPersonalBlog.Models.Filters;

public class TagFilterModel
{
    public IEnumerable<string> TagsToExclude { get; set; }
        = Enumerable.Empty<string>();
}