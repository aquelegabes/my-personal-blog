namespace MyPersonalBlog.Services;

public class LoadingService
{
    private bool _isLoading = false;
    public bool IsLoading => _isLoading;
    public event Action? Notify;

    public void SetLoading(bool state) {
        this._isLoading = state;
        Notify?.Invoke();
    }
}