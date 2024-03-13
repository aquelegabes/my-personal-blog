namespace MyPersonalBlog.Entities;

public class Artigo
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Caminho { get; set; } = string.Empty;
    public DateTimeOffset DataDePublicacao { get; set; } = DateTime.Now;
    public string Titulo { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;

    public Autor Autor { get; set; } = new();
    public IEnumerable<Tag> Tags { get; set; } = new List<Tag>();
    public IEnumerable<Idioma> IdiomasDisponiveis { get; set; } = new List<Idioma>();
}
