using System.Reflection;
using MyPersonalBlog.Entities;

namespace MyPersonalBlog.Services;

public class ArticleService
{
    private static readonly List<Article> articles =
        new()
        {
            new() {
                Author = new() { FullName = "Gabriel Santos" },
                Tags = new List<Tag>
                {
                    new() {Name = "Tecnologia"},
                    new() {Name = "Tech"},
                    new() {Name = "CyberSec"},
                },
                FilePath = Assembly.GetExecutingAssembly().Location,
                Slug = "o-processo-de-desenvolvimento-do-meu-blog-pessoal",
                Title = "O Processo de Desenvolvimento do meu Blog Pessoal"
            }
        };

    public IEnumerable<Article> GetArticles() =>
        articles.AsEnumerable();
}