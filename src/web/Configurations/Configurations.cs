using MyPersonalBlog.Services;
namespace MyPersonalBlog.Configurations;

public static class Configurations
{
    public static void AddAppServices(this IServiceCollection sc)
    {
        sc.AddSingleton<LoadingService>();
        sc.AddSingleton<ArticleService>();
    }

    public static void AddAppConfiguration(
        this WebApplicationBuilder builder)
    {
        var settings = new AppConfiguration();        
        builder.Configuration.GetSection("AppConfiguration").Bind(settings);
        builder.Services.AddSingleton(settings);
    }
}