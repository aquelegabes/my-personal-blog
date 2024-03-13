namespace MyPersonalBlog.Entities;

public class Autor
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string NomeCompleto { get; set; } = string.Empty;

    public string Nome
    {
        get
        {
            return
                this.NomeCompleto?.Split(' ').FirstOrDefault() ??
                string.Empty;
        }
    }
    public string Sobrenome
    {
        get
        {
            return
                this.NomeCompleto?.Split(' ').LastOrDefault() ??
                string.Empty;
        }
    }
}