using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Syrna.TemplateProject
{
    [DependsOn(
        typeof(TemplateProjectApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class TemplateProjectHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = TemplateProjectRemoteServiceConsts.RemoteServiceName;

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(TemplateProjectApplicationContractsModule).Assembly,
                RemoteServiceName
            );
            
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<TemplateProjectApplicationContractsModule>();
            });
        }
    }
}
