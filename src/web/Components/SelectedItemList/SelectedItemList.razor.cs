namespace MyPersonalBlog.Components.SelectedItemList;

public partial class SelectedItemList
{

    [Parameter]
    public ICollection<string> ItemsSelecionados { get; set; }
        = new List<string>();

    [Parameter]
    public ICollection<string> DataListOptions { get; set; }
        = new List<string>();

    [Parameter]
    public EventCallback<CancellationToken> AoRemoverItem { get; set; }

    private async Task AoRemoverItemSelecionado(MouseEventArgs args, string item)
    {
        ItemsSelecionados.Remove(item);
        DataListOptions.Add(item);
        await AoRemoverItem.InvokeAsync(CancellationToken.None);
    }
}