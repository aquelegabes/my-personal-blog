#pragma warning disable CS8602
using Microsoft.AspNetCore.Components;
using MyPersonalBlog.Services;

namespace MyPersonalBlog.Components.Utils.Loading;

public partial class LoadingComponent
{
    [Inject]
    public LoadingService? LoadingService { get; set; }

    public async override Task SetParametersAsync(ParameterView parameters)
    {
        await base.SetParametersAsync(parameters);

        LoadingService.Notificar += () => InvokeAsync(StateHasChanged);
    }
}