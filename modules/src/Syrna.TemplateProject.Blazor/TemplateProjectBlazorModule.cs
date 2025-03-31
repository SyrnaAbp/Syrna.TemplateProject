using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AspNetCore.Components.Web.Theming.Toolbars;
using Volo.Abp.AutoMapper;
using Volo.Abp.BlazoriseUI;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace Syrna.TemplateProject.Blazor
{
    [DependsOn(
        typeof(TemplateProjectApplicationContractsModule),
        typeof(AbpAspNetCoreComponentsWebThemingModule),
        typeof(AbpAutoMapperModule),
        typeof(AbpBlazoriseUIModule)
        )]
    public class TemplateProjectBlazorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpToolbarOptions>(options =>
            {
                options.Contributors.Add(new TemplateProjectToolbarContributor());
            });

            context.Services.AddAutoMapperObjectMapper<TemplateProjectBlazorModule>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<TemplateProjectBlazorAutoMapperProfile>(validate: true);
            });

            context.Services.AddAutoMapperObjectMapper<TemplateProjectBlazorModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<TemplateProjectBlazorModule>(validate: true);
            });
            
            //Configure<AbpNavigationOptions>(options =>
            //{
            //    options.MenuContributors.Add(new TemplateProjectMenuContributor());
            //});

            Configure<AbpRouterOptions>(options =>
            {
                options.AdditionalAssemblies.Add(typeof(TemplateProjectBlazorModule).Assembly);
            });
        }
    }
}