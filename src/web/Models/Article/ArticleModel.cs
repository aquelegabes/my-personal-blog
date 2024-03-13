namespace MyPersonalBlog.Models.Article;

public class ArticleModel
{
    public ArticleModel(string title, DateTime publishDate)
    {
        this.Titulo = title;
        this.DataDePublicacao = publishDate;
    }
    public string Titulo { get; set; } = string.Empty;
    public DateTime DataDePublicacao { get; set; }
    public IEnumerable<ChapterModel> Capitulos { get; set; } = Enumerable.Empty<ChapterModel>();
    public AuthorModel Autor { get; set; } = new();
}
