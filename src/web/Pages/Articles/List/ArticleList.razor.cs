#pragma warning disable CS8618
global using MyPersonalBlog.Models.Article;
namespace MyPersonalBlog.Pages.Articles.List;

public partial class ArticleList
{
    [Inject]
    private ArticleService? Service { get; set; }

    [Inject]
    private LoadingService LoadingService { get; set; }

    private IEnumerable<ArticleListItemModel> articleList { get; set; }
        = Enumerable.Empty<ArticleListItemModel>();

    private ArticleFilterModel Filter { get; set; } = new();

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        LoadingService.Notify += () => InvokeAsync(StateHasChanged);
    }

    protected override async Task OnInitializedAsync()
    {
        LoadingService.SetLoading(true);

        await Task.Delay(500);
        articleList = Service!.GetArticles(Filter);

        LoadingService.SetLoading(false);
    }

    private async Task OnFilter(CancellationToken cToken)
    {
        try
        {
            LoadingService.SetLoading(true);
            await Task.Delay(500);

            if (!cToken.IsCancellationRequested)
                articleList = Service!.GetArticles(Filter);
        }
        catch (Exception)
        {

        }
        finally
        {
            LoadingService.SetLoading(false);
        }
    }

}