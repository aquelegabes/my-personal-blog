using MyPersonalBlog.Services;
namespace MyPersonalBlog;

public static class Configurations
{
    public static void AddServices(this IServiceCollection sc)
    {
        sc.AddSingleton<LoadingService>();
    }
}