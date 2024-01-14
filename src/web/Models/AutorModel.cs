namespace MyPersonalBlog.Models;

public class AutorModel
{
    public AutorModel()
    {

    }
    public AutorModel(string nome)
    {
        this.Nome = nome;
    }
    public string Nome { get; set; } = string.Empty;
}