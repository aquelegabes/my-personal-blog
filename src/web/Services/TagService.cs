namespace MyPersonalBlog.Services;

public class TagService
{
    public IEnumerable<string> ObterTags(TagFilterModel filter)
    {
        return new List<string> {
            "CSharp",
            "CyberSec",
            ".NET",
            "Microsoft",
            "Desenvolvimento Web",
            ""
        }.Where(tag => filter.TagsParaRemover.Contains(tag));
    }
}