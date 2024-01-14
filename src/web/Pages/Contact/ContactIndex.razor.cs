#pragma warning disable CS8618
using System.Reflection;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using MyPersonalBlog.Configurations;

namespace MyPersonalBlog.Pages.Contact;

public partial class ContactIndex
{
    [Inject]
    private AppConfiguration AppConfig { get; set; }

    private SocialMediaInfo[] infos;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        this.infos = AppConfig.SocialMediaInfos;
    }
}