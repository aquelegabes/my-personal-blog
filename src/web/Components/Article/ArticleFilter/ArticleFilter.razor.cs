namespace MyPersonalBlog.Components.Article.ArticleFilter;

public partial class ArticleFilter
{
    [Parameter]
    public EventCallback<CancellationToken> AoFiltrar { get; set; }

    [Parameter]
    public ArticleFilterModel Model { get; set; } = new();

    private async Task OnTitleFilter(KeyboardEventArgs e)
    {
        var ctoken = CancellationToken.None;

        if (e.Code == "Enter" || e.Code == "NumpadEnter")
        {
            await this.AoFiltrar.InvokeAsync(ctoken);
        }
    }
}