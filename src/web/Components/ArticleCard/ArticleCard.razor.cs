using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Razor.TagHelpers;
using MyPersonalBlog.Models;

namespace MyPersonalBlog.Components.ArticleCard;

public partial class ArticleCard
{
    private const int MAX_TAGS_PER_LINE = 5;
    private bool hasNextPage = false;

    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string DisplayContent { get; set; } = string.Empty;

    [Parameter]
    public string Href { get; set; } = string.Empty;

    [Parameter]
    public IEnumerable<TagModel> Tags { get; set; } =
        new List<TagModel>();

    protected override void OnInitialized()
    {
        base.OnInitialized();
        hasNextPage = Tags.Any();
    }
}