namespace MyPersonalBlog.Services;

public class LoadingService
{
    private bool _estaCarregando = false;
    public bool EstaCarregando => _estaCarregando;
    public event Action? Notificar;

    public void AlterarEstado(bool estado)
    {
        this._estaCarregando = estado;
        Notificar?.Invoke();
    }
}