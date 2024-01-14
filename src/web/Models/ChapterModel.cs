namespace MyPersonalBlog.Models;

public class ChapterModel
{
    public ChapterModel(string title, string content)
    {
        this.Title = title;
        this.Content = content;
    }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
}