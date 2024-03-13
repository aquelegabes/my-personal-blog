namespace MyPersonalBlog.Models;

public class ChapterModel
{
    public ChapterModel(string title, string content)
    {
        this.Titulo = title;
        this.Conteudo = content;
    }
    public string Titulo { get; set; } = string.Empty;
    public string Conteudo { get; set; } = string.Empty;
    public string[] ObterParagrafos()
    {
        return Conteudo.Split('\r');
    }
}