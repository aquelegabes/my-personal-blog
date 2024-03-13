namespace MyPersonalBlog.Components.Article.ArticleCard;

public partial class ArticleCard
{
    [Parameter]
    public ArticleListItemModel Artigo { get; set; } = new();

    [Parameter]
    public EventCallback<TagModel> AoAdicionarTagNoFiltro { get; set; }
}