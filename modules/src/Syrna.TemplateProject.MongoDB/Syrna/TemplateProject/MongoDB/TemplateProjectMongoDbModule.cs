using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace Syrna.TemplateProject.MongoDB
{
    [DependsOn(
        typeof(TemplateProjectDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class TemplateProjectMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<TemplateProjectMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
