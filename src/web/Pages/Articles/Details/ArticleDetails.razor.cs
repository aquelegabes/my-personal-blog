#pragma warning disable CS8618
using Microsoft.AspNetCore.Components;
using MyPersonalBlog.Models;
using MyPersonalBlog.Services;

namespace MyPersonalBlog.Pages.Articles.Details;

public partial class ArticleDetails
{
    [Inject]
    private LoadingService? LoadingService { get; set; }

    [Parameter]
    public string Idioma { get; set; }

    [Parameter]
    public string Titulo { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        this.artigo = new("Titulo 1", DateTime.Today)
        {
            Autor = new("Gabriel Santos"),
            Capitulos = new List<CapituloModel>()
{
new("Capitulo 1 - caracteristicas de um", "Laboris ad est ullamco ad ea aute. Amet ipsum esse id incididunt."),
new("Capitulo 2 - yabbadabba doo", "Laboris ad est ullamco ad ea aute. Amet ipsum esse id incididunt."),
new("Capitulo 3 - hasdoias asd adsas", "Laboris ad est ullamco ad ea aute. Amet ipsum esse id incididunt."),
new("Capitulo 4 - asd asdasdddd sd", "Laboris ad est ullamco ad ea aute. Amet ipsum esse id incididunt."),
new("Capitulo 5 - adsdas sdas dsa", "Laboris ad est ullamco ad ea aute. Amet ipsum esse id incididunt."),
new("Capitulo 6 - asdasas dasasd", "Laboris ad est ullamco ad ea aute. Amet ipsum esse id incididunt."),
new("Capitulo 7 - iogjiodjfgp", "Laboris ad est ullamco ad ea aute. Amet ipsum esse id incididunt."),
new("Capitulo 8 - ioqwioe oqweiouq oqwe", "Laboris ad est ullamco ad ea aute. Amet ipsum esse id incididunt."),
new("Capitulo 9 - aosidj iouqwe", "Laboris ad est ullamco ad ea aute. Amet ipsum esse id incididunt."),
new("Capitulo 10 - aosidj iouqwe", "Laboris ad est ullamco ad ea aute. Amet ipsum esse id incididunt."),
new("Capitulo 11 - aosidj iouqwe", "Laboris ad est ullamco ad ea aute. Amet ipsum esse id incididunt."),
new("Capitulo 12 - aosidj iouqwe", "Laboris ad est ullamco ad ea aute. Amet ipsum esse id incididunt."),
}
        };

        this.LoadingService?.SetLoading(true);
        await Task.Delay(1000);
        this.LoadingService?.SetLoading(false);
    }

    public ArtigoModel artigo;
}