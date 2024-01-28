namespace MyPersonalBlog.Components.Input.InputTags;

public partial class InputTags
{
    [Parameter]
    public ICollection<string> SelectedTags { get; set; } =
        new List<string>();

    [Parameter]
    public EventCallback<CancellationToken> OnAddItemCallback { get; set; }

    [Parameter]
    public EventCallback<CancellationToken> OnRemoveItemCallback { get; set; }

    private string InputValue { get; set; }
        = string.Empty;

    private CancellationTokenSource CancellationTokenSource { get; set; }
        = new();

    private ICollection<string> DataListOptions { get; set; } =
        new List<string>();

    private void OnTextChange(ChangeEventArgs args)
    {
        InputValue = args?.Value?.ToString() ?? string.Empty;
    }

    private async Task OnSelectTag(KeyboardEventArgs args)
    {
        switch (args.Code)
        {
            case "Comma":
            case "Enter":
                HandleCancellationToken();
                HandleTagSelection();

                await OnAddItemCallback.InvokeAsync(CancellationTokenSource.Token);

                break;
            default: return;
        }

        StateHasChanged();
    }

    private void HandleCancellationToken()
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

    private void HandleTagSelection()
    {
        InputValue = InputValue
                        .Replace(",", "")
                        .Trim();

        bool inputHasValue = !string.IsNullOrWhiteSpace(InputValue);
        bool isInputDuplicated =
            SelectedTags
            .Any(s => s.Equals(InputValue, StringComparison.OrdinalIgnoreCase));

        if (inputHasValue && !isInputDuplicated)
        {
            SelectedTags.Add(InputValue);
            DataListOptions.Remove(InputValue);
        }

        InputValue = string.Empty;
    }
}
