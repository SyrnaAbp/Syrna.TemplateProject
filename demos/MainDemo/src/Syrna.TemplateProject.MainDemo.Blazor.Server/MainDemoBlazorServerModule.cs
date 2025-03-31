using Volo.Abp.Modularity;

namespace Syrna.TemplateProject.MainDemo.Blazor.Server;

[DependsOn(
    typeof(MainDemoBlazorModule)
)]
public class MainDemoBlazorServerModule : AbpModule
{

}
