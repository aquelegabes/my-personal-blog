namespace MyPersonalBlog.Models;

public class AuthorModel
{
    public AuthorModel()
    {

    }
    public AuthorModel(string nome)
    {
        this.Nome = nome;
    }
    public string Nome { get; set; } = string.Empty;
}