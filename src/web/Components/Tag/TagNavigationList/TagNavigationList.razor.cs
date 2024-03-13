namespace MyPersonalBlog.Components.Tag.TagNavigationList;

public partial class TagNavigationList
{
    private const int MAXIMO_DE_TAGS_POR_LINHA = 5;
    private bool temProximaPagina = false;

    [Parameter]
    public IEnumerable<TagModel> Tags { get; set; } =
        new List<TagModel>();

    [Parameter]
    public int MaximoDeTagsPorLinha { get; set; } = MAXIMO_DE_TAGS_POR_LINHA;

    [Parameter]
    public EventCallback<TagModel> AoAdicionarTagNoFiltro { get; set; }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        this.temProximaPagina = Tags.Any();
    }

    private async Task AoClicarNaTag(TagModel tag)
    {
        await AoAdicionarTagNoFiltro.InvokeAsync(tag);
    }
}