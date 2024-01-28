#pragma warning disable CS8618
namespace MyPersonalBlog.Components.Article.ArticleCard;

public partial class ArticleCard
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string DisplayContent { get; set; } = string.Empty;

    [Parameter]
    public string Href { get; set; } = string.Empty;

    [Parameter]
    public IEnumerable<TagModel> Tags { get; set; } =
        new List<TagModel>();
}