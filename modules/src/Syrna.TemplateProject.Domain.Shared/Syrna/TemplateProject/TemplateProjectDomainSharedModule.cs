using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Syrna.TemplateProject.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace Syrna.TemplateProject
{
    [DependsOn(
        typeof(AbpValidationModule),
        typeof(AbpDddDomainSharedModule)
    )]
    public class TemplateProjectDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<TemplateProjectDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<TemplateProjectResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Syrna/TemplateProject/Localization");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("SyrnaTemplateProject", typeof(TemplateProjectResource));
            });
        }
    }
}
