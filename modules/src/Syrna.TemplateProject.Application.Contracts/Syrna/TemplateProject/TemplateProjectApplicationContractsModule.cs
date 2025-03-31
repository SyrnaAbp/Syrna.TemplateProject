using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.Authorization;

namespace Syrna.TemplateProject
{
    [DependsOn(
        typeof(TemplateProjectDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class TemplateProjectApplicationContractsModule : AbpModule
    {

    }
}
