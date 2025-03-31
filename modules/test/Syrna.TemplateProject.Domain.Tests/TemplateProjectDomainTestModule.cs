using Syrna.TemplateProject.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Syrna.TemplateProject
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(TemplateProjectEntityFrameworkCoreTestModule)
        )]
    public class TemplateProjectDomainTestModule : AbpModule
    {
        
    }
}
