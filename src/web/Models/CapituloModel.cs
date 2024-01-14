namespace MyPersonalBlog.Models;

public class CapituloModel
{
    public CapituloModel(string titulo, string conteudo)
    {
        this.Titulo = titulo;
        this.Conteudo = conteudo;
    }
    public string Titulo { get; set; } = string.Empty;
    public string Conteudo { get; set; } = string.Empty;
}