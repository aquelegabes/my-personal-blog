namespace MyPersonalBlog.Models;

public class Artigo
{
    public Artigo(string titulo, DateTime dataPublicacao)
    {
        this.Titulo = titulo;
        this.DataPublicacao = dataPublicacao;
    }
    public string Titulo { get; set; } = string.Empty;
    public DateTime DataPublicacao { get; set; }
    public IEnumerable<Capitulo> Capitulos { get; set; } = Enumerable.Empty<Capitulo>();
    public Autor Autor { get; set; } = new();
}
