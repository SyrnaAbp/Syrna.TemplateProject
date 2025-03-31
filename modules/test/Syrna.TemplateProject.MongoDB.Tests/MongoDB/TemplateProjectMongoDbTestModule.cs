using System;
using Volo.Abp;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace Syrna.TemplateProject.MongoDB
{
    [DependsOn(
        typeof(TemplateProjectTestBaseModule),
        typeof(TemplateProjectMongoDbModule)
        )]
    public class TemplateProjectMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = MongoDbFixture.GetRandomConnectionString();
            });
        }
    }
}