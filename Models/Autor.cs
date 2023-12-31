namespace MyPersonalBlog.Models;

public class Autor
{
    public Autor()
    {

    }
    public Autor(string nome)
    {
        this.Nome = nome;
    }
    public string Nome { get; set; } = string.Empty;
}