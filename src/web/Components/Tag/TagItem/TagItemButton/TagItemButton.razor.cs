#pragma warning disable CS8618
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MyPersonalBlog.Models;

namespace MyPersonalBlog.Components.Tag.TagItem.TagItemButton;

public partial class TagItemButton
{
    [Parameter]
    public TagModel Tag { get; set; } = new();

    [Parameter]
    public EventCallback<MouseEventArgs> OnClickAction { get; set; }
}