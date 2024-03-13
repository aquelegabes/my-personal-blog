#pragma warning disable CS8618
global using MyPersonalBlog.Models.Article;

namespace MyPersonalBlog.Pages.Articles.List;

public partial class ArticleList
{
    [Inject]
    private ArticleService? Service { get; set; }

    [Inject]
    private LoadingService LoadingService { get; set; }

    private IEnumerable<ArticleListItemModel> listaDeArtigos { get; set; }
        = Enumerable.Empty<ArticleListItemModel>();

    private ArticleFilterModel Filter { get; set; } = new();

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        LoadingService.Notificar += () => InvokeAsync(StateHasChanged);
    }

    protected override async Task OnInitializedAsync()
    {
        await AoFiltrar(CancellationToken.None);
    }

    private async Task AoAdicionarTagNoFiltro(TagModel tag)
    {
        bool isTagFiltered =
                Filter.Tags
                .Any(s => s.Equals(tag.Nome, StringComparison.OrdinalIgnoreCase));

        if (!isTagFiltered)
        {
            Filter.Tags.Add(tag.Nome);
        }

        await AoFiltrar(CancellationToken.None);
    }

    private async Task AoFiltrar(CancellationToken cToken)
    {
        try
        {
            LoadingService.AlterarEstado(true);
            listaDeArtigos = Enumerable.Empty<ArticleListItemModel>();
            StateHasChanged();
            await Task.Delay(500);

            if (!cToken.IsCancellationRequested)
                listaDeArtigos = Service!.GetArticles(Filter);
        }
        catch (Exception) { }
        finally
        {
            LoadingService.AlterarEstado(false);
            StateHasChanged();
        }
    }

}