using Volo.Abp.Modularity;

namespace Syrna.TemplateProject
{
    [DependsOn(
        typeof(TemplateProjectDomainSharedModule)
        )]
    public class TemplateProjectDomainModule : AbpModule
    {

    }
}
