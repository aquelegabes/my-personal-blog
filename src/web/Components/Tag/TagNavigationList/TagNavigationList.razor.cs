namespace MyPersonalBlog.Components.Tag.TagNavigationList;

public partial class TagNavigationList
{
    private const int MAX_TAGS_PER_LINE = 5;
    private bool hasNextPage = false;

    [Parameter]
    public IEnumerable<TagModel> Tags { get; set; } =
        new List<TagModel>();

    [Parameter]
    public int MaxTagsPerLine { get;set; } = MAX_TAGS_PER_LINE;

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        this.hasNextPage = Tags.Any();
    }
}