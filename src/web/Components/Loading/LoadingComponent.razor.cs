using Microsoft.AspNetCore.Components;
using MyPersonalBlog.Services;

namespace MyPersonalBlog.Components.Loading;

public partial class LoadingComponent
{
    [Inject]
    public LoadingService? LoadingService { get; set; }

    public async override Task SetParametersAsync(ParameterView parameters)
    {
        await base.SetParametersAsync(parameters);

        LoadingService.Notify += () => InvokeAsync(StateHasChanged);
    }
}