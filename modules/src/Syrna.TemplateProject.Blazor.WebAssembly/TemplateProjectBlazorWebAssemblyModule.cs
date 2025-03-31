using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Syrna.TemplateProject.Blazor.WebAssembly
{
    [DependsOn(
        typeof(TemplateProjectBlazorModule),
        typeof(TemplateProjectHttpApiClientModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
        )]
    public class TemplateProjectBlazorWebAssemblyModule : AbpModule
    {
        
    }
}