namespace MyPersonalBlog.Models.Article;

public class ArticleModel
{
    public ArticleModel(string title, DateTime publishDate)
    {
        this.Title = title;
        this.PublishDate = publishDate;
    }
    public string Title { get; set; } = string.Empty;
    public DateTime PublishDate { get; set; }
    public IEnumerable<ChapterModel> Chapters { get; set; } = Enumerable.Empty<ChapterModel>();
    public AuthorModel Author { get; set; } = new();
}
