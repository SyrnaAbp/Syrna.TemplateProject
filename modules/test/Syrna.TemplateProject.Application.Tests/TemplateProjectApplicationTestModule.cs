using Volo.Abp.Modularity;

namespace Syrna.TemplateProject
{
    [DependsOn(
        typeof(TemplateProjectApplicationModule),
        typeof(TemplateProjectDomainTestModule)
        )]
    public class TemplateProjectApplicationTestModule : AbpModule
    {

    }
}
