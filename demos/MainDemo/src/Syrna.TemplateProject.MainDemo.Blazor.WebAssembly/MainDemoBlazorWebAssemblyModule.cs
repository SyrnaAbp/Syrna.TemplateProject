using Syrna.TemplateProject.MainDemo.Blazor;
using Volo.Abp.Modularity;

namespace Syrna.TemplateProject.MainDemo.Blazor.WebAssembly;

[DependsOn(
    typeof(MainDemoBlazorModule)
)]
public class MainDemoBlazorWebAssemblyModule : AbpModule
{
}
