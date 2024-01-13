using Microsoft.AspNetCore.Components;

namespace MyPersonalBlog.Components.ArticleCard;

public partial class ArticleCard
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string DisplayContent { get; set; } = string.Empty;

    [Parameter]
    public IDictionary<string, string> Tags { get; set; } =
        new Dictionary<string, string>();
}