namespace MyPersonalBlog.Components.Input.InputSearch;

public partial class InputSearch
{
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> InputAttributes { get; set; }
        = new();

    [Parameter]
    public IEnumerable<string> DataListOptions { get;set; } =
        Enumerable.Empty<string>();
}
