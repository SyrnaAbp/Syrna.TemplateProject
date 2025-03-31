using Localization.Resources.AbpUi;
using Syrna.TemplateProject.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Syrna.TemplateProject
{
    [DependsOn(
        typeof(TemplateProjectApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class TemplateProjectHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(TemplateProjectHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<TemplateProjectResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
