using MyPersonalBlog.Pages.Articles.List;

namespace MyPersonalBlog.Services;

public class ArticleService
{
    private static readonly List<ArticleListItemModel> articles =
        new()
        {
            new() {
                Title = "O Processo de Desenvolvimento do meu Blog Pessoal",
                DisplayContent = "Magna deserunt in eu laboris esse proident. Incididunt sit nisi ex irure. Id nisi et excepteur Lorem aute eu quis amet labore et sunt esse consectetur velit. Eiusmod eiusmod occaecat sint ut magna Lorem sunt magna. Ea ex ullamco consequat consequat Lorem. Nulla deserunt aliquip aliqua do ex velit esse veniam nisi. Consequat non ea voluptate in labore nostrud anim ea quis sit aliqua officia deserunt...",
                Url = "",
                Tags = new List<TagModel> {
                    new() { Name = "CSharp" },
                    new() { Name = "Blog" },
                    new() { Name = ".NET" },
                    new() { Name = "Microsoft" },
                },
            },
            new() {
                Title = "Artigo numero 2",
                DisplayContent = "Magna deserunt in eu laboris esse proident. Incididunt sit nisi ex irure. Id nisi et excepteur Lorem aute eu quis amet labore et sunt esse consectetur velit. Eiusmod eiusmod occaecat sint ut magna Lorem sunt magna. Ea ex ullamco consequat consequat Lorem. Nulla deserunt aliquip aliqua do ex velit esse veniam nisi. Consequat non ea voluptate in labore nostrud anim ea quis sit aliqua officia deserunt...",
                Url = "",
                Tags = new List<TagModel> {
                    new() { Name = "Artigo" },
                    new() { Name = "Processo" },
                    new() { Name = ".NET" },
                    new() { Name = "Desenvolvimento" },
                },
            },
            new() {
                Title = "Artigo numero 3",
                DisplayContent = "Magna deserunt in eu laboris esse proident. Incididunt sit nisi ex irure. Id nisi et excepteur Lorem aute eu quis amet labore et sunt esse consectetur velit. Eiusmod eiusmod occaecat sint ut magna Lorem sunt magna. Ea ex ullamco consequat consequat Lorem. Nulla deserunt aliquip aliqua do ex velit esse veniam nisi. Consequat non ea voluptate in labore nostrud anim ea quis sit aliqua officia deserunt...",
                Url = "",
                Tags = new List<TagModel> {
                    new() { Name = "DLL" },
                    new() { Name = "Microsoft" },
                    new() { Name = ".NET" },
                    new() { Name = "Armazenamento" },
                },
            },
        };

    public IEnumerable<ArticleListItemModel> GetArticles(
        ArticleFilterModel filter)
    {
        if (!filter.Tags.Any())
            return articles.AsEnumerable();

        var queryArticles = 
            from article in articles
            where article.Tags.Any(tag => filter.Tags.Contains(tag.Name))
            select article;

        return queryArticles.AsEnumerable();
    }
}