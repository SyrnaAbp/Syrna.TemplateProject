using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace Syrna.TemplateProject
{
    [DependsOn(
        typeof(TemplateProjectDomainModule),
        typeof(TemplateProjectApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class TemplateProjectApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<TemplateProjectApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<TemplateProjectApplicationModule>();
            });
        }
    }
}
