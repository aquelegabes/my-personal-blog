namespace MyPersonalBlog.Components.Input.InputTags;

public partial class InputTags
{
    [Parameter]
    public ICollection<string> TagsSelecionadas { get; set; } =
        new List<string>();

    [Parameter]
    public EventCallback<CancellationToken> AoAdicionarItem { get; set; }

    [Parameter]
    public EventCallback<CancellationToken> AoRemoverItem { get; set; }

    private string InputValue { get; set; }
        = string.Empty;

    private CancellationTokenSource CancellationTokenSource { get; set; }
        = new();

    private ICollection<string> DataListOptions { get; set; } =
        new List<string>();

    private void AoAlterarTexto(ChangeEventArgs args)
    {
        InputValue = args?.Value?.ToString().Trim() ?? string.Empty;
    }

    private async Task AoSelecionarTag(KeyboardEventArgs args)
    {
        switch (args.Code)
        {
            case "Comma":
            case "Enter":
                TratarCancellationToken();
                TratarSelecaoDeTag();

                await AoAdicionarItem.InvokeAsync(CancellationTokenSource.Token);

                break;
            default: return;
        }

        StateHasChanged();
    }

    private void TratarCancellationToken()
    {
        try
        {
            CancellationTokenSource.Cancel();
            CancellationTokenSource.Token.ThrowIfCancellationRequested();
        }
        catch (OperationCanceledException) { }
        catch (ObjectDisposedException) { }
        finally
        {
            bool isReset = CancellationTokenSource.TryReset();
            if (!isReset)
            {
                CancellationTokenSource = new();
            }
        }
    }

    private void TratarSelecaoDeTag()
    {
        InputValue = InputValue
                        .Replace(",", "")
                        .Trim();

        bool inputHasValue = !string.IsNullOrWhiteSpace(InputValue);
        bool isInputDuplicated =
            TagsSelecionadas
            .Any(s => s.Equals(InputValue, StringComparison.OrdinalIgnoreCase));

        if (inputHasValue && !isInputDuplicated)
        {
            TagsSelecionadas.Add(InputValue);
            DataListOptions.Remove(InputValue);
        }

        InputValue = string.Empty;
    }
}
