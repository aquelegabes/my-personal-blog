namespace MyPersonalBlog.Components.Article.ArticleFilter;

public partial class ArticleFilter
{
    [Parameter]
    public EventCallback<CancellationToken> OnFilter { get; set; }

    [Parameter]
    public ArticleFilterModel Model { get; set; } = new();
}