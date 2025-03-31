using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Syrna.TemplateProject.Blazor.Server
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsServerThemingModule),
        typeof(TemplateProjectBlazorModule)
        )]
    public class TemplateProjectBlazorServerModule : AbpModule
    {
        
    }
}