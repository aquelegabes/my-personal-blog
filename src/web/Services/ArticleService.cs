namespace MyPersonalBlog.Services;

public class ArticleService
{
    private static readonly List<ArticleListItemModel> articles =
        new()
        {
            new() {
                Titulo = "O Processo de Desenvolvimento do meu Blog Pessoal",
                Conteudo = "Magna deserunt in eu laboris esse proident. Incididunt sit nisi ex irure. Id nisi et excepteur Lorem aute eu quis amet labore et sunt esse consectetur velit. Eiusmod eiusmod occaecat sint ut magna Lorem sunt magna. Ea ex ullamco consequat consequat Lorem. Nulla deserunt aliquip aliqua do ex velit esse veniam nisi. Consequat non ea voluptate in labore nostrud anim ea quis sit aliqua officia deserunt...",
                Url = "",
                Tags = new List<TagModel> {
                    new() { Nome = "CSharp" },
                    new() { Nome = "Blog" },
                    new() { Nome = ".NET" },
                    new() { Nome = "Microsoft" },
                },
                DataDePublicacao = DateTimeOffset.Now
            },
            new() {
                Titulo = "Artigo numero 2",
                Conteudo = "Magna deserunt in eu laboris esse proident. Incididunt sit nisi ex irure. Id nisi et excepteur Lorem aute eu quis amet labore et sunt esse consectetur velit. Eiusmod eiusmod occaecat sint ut magna Lorem sunt magna. Ea ex ullamco consequat consequat Lorem. Nulla deserunt aliquip aliqua do ex velit esse veniam nisi. Consequat non ea voluptate in labore nostrud anim ea quis sit aliqua officia deserunt...",
                Url = "",
                Tags = new List<TagModel> {
                    new() { Nome = "Artigo" },
                    new() { Nome = "Processo" },
                    new() { Nome = ".NET" },
                    new() { Nome = "Desenvolvimento" },
                },
                DataDePublicacao = new DateTimeOffset(new DateTime(2024,9,4), TimeSpan.FromHours(3))
            },
            new() {
                Titulo = "Artigo numero 3",
                Conteudo = "Magna deserunt in eu laboris esse proident. Incididunt sit nisi ex irure. Id nisi et excepteur Lorem aute eu quis amet labore et sunt esse consectetur velit. Eiusmod eiusmod occaecat sint ut magna Lorem sunt magna. Ea ex ullamco consequat consequat Lorem. Nulla deserunt aliquip aliqua do ex velit esse veniam nisi. Consequat non ea voluptate in labore nostrud anim ea quis sit aliqua officia deserunt...",
                Url = "",
                Tags = new List<TagModel> {
                    new() { Nome = "DLL" },
                    new() { Nome = "Microsoft" },
                    new() { Nome = ".NET" },
                    new() { Nome = "Armazenamento" },
                },
                DataDePublicacao = new DateTimeOffset(new DateTime(2023,4,15), TimeSpan.FromHours(3))
            },
        };

    public IEnumerable<ArticleListItemModel> GetArticles(
        ArticleFilterModel filter)
    {
        var queryArticles = articles.AsQueryable();

        if (filter.Tags.Any())
            queryArticles =
                from article in queryArticles
                where article.Tags.Any(tag => filter.Tags.Contains(tag.Nome))
                select article;

        if (!string.IsNullOrWhiteSpace(filter.Titulo))
            queryArticles =
                from article in queryArticles
                where article.Titulo.Contains(filter.Titulo, StringComparison.InvariantCultureIgnoreCase)
                select article;

        return queryArticles.OrderByDescending(_ => _.DataDePublicacao);
    }
}