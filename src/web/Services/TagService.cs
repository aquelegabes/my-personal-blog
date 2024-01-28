namespace MyPersonalBlog.Services;

public class TagService {
    public IEnumerable<string> GetTags(TagFilterModel filter) {
        return new List<string> {
            "CSharp",
            "CyberSec",
            ".NET",
            "Microsoft",
            "Desenvolvimento Web",
            ""
        }.Where(tag => filter.TagsToExclude.Contains(tag));
    }
}