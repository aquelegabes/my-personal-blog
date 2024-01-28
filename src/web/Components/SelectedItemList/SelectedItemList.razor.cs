namespace MyPersonalBlog.Components.SelectedItemList;

public partial class SelectedItemList
{

    [Parameter]
    public ICollection<string> SelectedItems { get; set; }
        = new List<string>();

    [Parameter]
    public ICollection<string> DataListOptions { get; set; }
        = new List<string>();

    [Parameter]
    public EventCallback<CancellationToken> OnRemoveItemCallback { get; set; }

    private async Task OnRemoveSelectedItem(MouseEventArgs args, string item)
    {
        SelectedItems.Remove(item);
        DataListOptions.Add(item);
        await OnRemoveItemCallback.InvokeAsync(CancellationToken.None);
        StateHasChanged();
    }
}