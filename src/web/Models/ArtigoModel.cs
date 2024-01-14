namespace MyPersonalBlog.Models;

public class ArtigoModel
{
    public ArtigoModel(string titulo, DateTime dataPublicacao)
    {
        this.Titulo = titulo;
        this.DataPublicacao = dataPublicacao;
    }
    public string Titulo { get; set; } = string.Empty;
    public DateTime DataPublicacao { get; set; }
    public IEnumerable<CapituloModel> Capitulos { get; set; } = Enumerable.Empty<CapituloModel>();
    public AutorModel Autor { get; set; } = new();
}
