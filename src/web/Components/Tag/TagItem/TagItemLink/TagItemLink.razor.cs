#pragma warning disable CS8618
namespace MyPersonalBlog.Components.Tag.TagItem.TagItemLink;

public partial class TagItemLink
{
    [Parameter]
    public bool IsListItem { get; set; } = false;

    [Parameter]
    public TagModel Tag { get; set; } = new();
}