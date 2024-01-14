using MyPersonalBlog.Models;

namespace MyPersonalBlog.Pages.Articles.List;

public partial class ArticleList
{
    public string Title1 = "Ea dolore esse ipsum";
    public string DisplayContent1 = "Pariatur quis nulla non mollit nulla amet cupidatat laboris. In consectetur qui do irure esse elit. Quis Lorem sint mollit nulla qui sunt tempor est proident nulla consequat. Sunt fugiat fugiat occaecat veniam id adipisicing in id. Ex reprehenderit officia consectetur nostrud et ullamco tempor...";
    public IEnumerable<TagModel> Tags1 = 
        new List<TagModel> 
        {
            new("Tecnologia"),
            new("CyberSec"),
            new("CSharp"),
            new("C#"),
            new(".NET"),
            new("Tech"),
            new("Engenharia de Software"),
            new("Software"),
            new("Engenharia"),
            new("Backend"),
            new("Microsoft"),
            new("DOTNET"),
        };
}