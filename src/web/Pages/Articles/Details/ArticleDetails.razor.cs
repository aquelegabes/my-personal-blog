#pragma warning disable CS8618

namespace MyPersonalBlog.Pages.Articles.Details;

public partial class ArticleDetails
{
    private bool isMenuShowing = true;

    [Inject]
    private LoadingService? LoadingService { get; set; }

    [Parameter]
    public string Language { get; set; }

    [Parameter]
    public string Title { get; set; }

    private void ToggleMenu()
    {
        this.isMenuShowing = !this.isMenuShowing;
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
    }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        this.artigo = new("Titulo 1", DateTime.Today)
        {
            Autor = new("Gabriel Santos"),
            Capitulos = new List<ChapterModel>()
{
new("Capitulo 1 - caracteristicas de um", "Laboris ad est ullamco ad ea aute. Amet ipsum esse id incididunt. Elit ex sint id proident fugiat dolore ut.\rOccaecat est aliquip laborum sunt in minim commodo tempor sint non et. Excepteur tempor tempor commodo tempor nostrud exercitation voluptate labore aute excepteur enim excepteur laboris non.\rIn est Lorem est dolore velit commodo. Dolor reprehenderit laboris in nostrud duis esse ullamco officia fugiat cillum mollit quis. Sunt velit aliqua commodo ullamco incididunt magna do duis laboris adipisicing qui veniam ut.\rNisi sint excepteur adipisicing deserunt ad duis pariatur aliqua deserunt incididunt nulla. Fugiat quis ut cupidatat excepteur esse esse labore velit dolore elit commodo non proident. Adipisicing est minim eu cupidatat minim aute."),
new("Capitulo 2 - yabbadabba doo", "Laboris ad est ullamco ad ea aute. Amet ipsum esse id incididunt. Ex magna esse aliqua aliquip ad aliquip aute consectetur dolor labore. Exercitation minim eiusmod duis excepteur id.\rVoluptate voluptate ea fugiat non ullamco ex et mollit enim. Ea velit laborum deserunt aute excepteur. Occaecat dolore proident laboris anim voluptate magna irure ea. Ut minim non sunt dolore amet esse commodo est consectetur Lorem Lorem.\rElit adipisicing sit qui amet. Fugiat dolor sint minim sint. Cillum pariatur cillum enim ex sint deserunt consectetur aliqua est.\rExcepteur mollit nostrud quis ad ex est.Elit eiusmod aute minim dolore voluptate. Sunt nisi aute officia do id irure laborum non enim esse. Quis labore ut do aliquip."),
new("Capitulo 3 - hasdoias asd adsas", "Laboris ad est ullamco ad ea aute. Amet ipsum esse id incididunt."),
}
        };

        this.LoadingService?.AlterarEstado(true);
        await Task.Delay(1000);
        this.LoadingService?.AlterarEstado(false);
    }

    public ArticleModel artigo;
}