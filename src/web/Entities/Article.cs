namespace MyPersonalBlog.Entities;

public class Article
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string FilePath { get; set; } = string.Empty;
    public DateTimeOffset PublishDate { get; set; } = DateTime.Now;
    public string Title { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;

    public Author Author { get; set; } = new();
    public IEnumerable<Tag> Tags { get; set; } = new List<Tag>();
    public IEnumerable<Language> AvailableLanguages { get; set; } = new List<Language>();
}
