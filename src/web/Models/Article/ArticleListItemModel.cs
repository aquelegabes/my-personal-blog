namespace MyPersonalBlog.Models.Article;

public class ArticleListItemModel
{
    public string Title { get; set; } = string.Empty;
    public string DisplayContent { get; set; } = string.Empty;
    public IEnumerable<TagModel> Tags = Enumerable.Empty<TagModel>();
    public string Url { get;set; }= string.Empty;
}