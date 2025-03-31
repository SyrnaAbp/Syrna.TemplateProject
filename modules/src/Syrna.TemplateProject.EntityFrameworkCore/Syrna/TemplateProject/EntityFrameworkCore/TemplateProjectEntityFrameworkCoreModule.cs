using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Syrna.TemplateProject.EntityFrameworkCore
{
    [DependsOn(
        typeof(TemplateProjectDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class TemplateProjectEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<TemplateProjectDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}
