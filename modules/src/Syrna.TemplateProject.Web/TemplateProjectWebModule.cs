using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Syrna.TemplateProject.Localization;
using Volo.Abp.AspNetCore.Mvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Syrna.TemplateProject.Web
{
    [DependsOn(
        typeof(TemplateProjectApplicationContractsModule),
        typeof(AbpAspNetCoreMvcUiThemeSharedModule),
        typeof(AbpAutoMapperModule)
        )]
    public class TemplateProjectWebModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
            {
                options.AddAssemblyResource(typeof(TemplateProjectResource), typeof(TemplateProjectWebModule).Assembly);
            });

            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(TemplateProjectWebModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpToolbarOptions>(options =>
            {
                options.Contributors.Add(new TemplateProjectToolbarContributor());
            });

            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<TemplateProjectWebModule>();
            });

            context.Services.AddAutoMapperObjectMapper<TemplateProjectWebModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<TemplateProjectWebModule>(validate: true);
            });

            Configure<RazorPagesOptions>(options =>
            {
                //Configure authorization.
            });
            
            //Configure<AbpBundlingOptions>(options =>
            //{
            //    options
            //        .StyleBundles
            //        .Configure(StandardBundles.Styles.Global, bundle => {
            //            bundle.AddContributors(typeof(PmNotificationStyleBundleContributor));
            //        });
                
            //    options
            //        .ScriptBundles
            //        .Configure(StandardBundles.Scripts.Global, bundle => {
            //            bundle.AddContributors(typeof(PmNotificationScriptBundleContributor));
            //        });
            //});
        }
    }
}
