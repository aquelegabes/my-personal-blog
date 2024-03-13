namespace MyPersonalBlog.Models.Article;

public class ArticleListItemModel
{
    public string Titulo { get; set; } = string.Empty;
    public string Conteudo { get; set; } = string.Empty;
    public IEnumerable<TagModel> Tags = Enumerable.Empty<TagModel>();
    public string Url { get; set; } = string.Empty;
    public DateTimeOffset DataDePublicacao { get; set; } = DateTimeOffset.MinValue;
}