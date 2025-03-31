using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Syrna.TemplateProject
{
    [DependsOn(
        typeof(TemplateProjectHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class TemplateProjectConsoleApiClientModule : AbpModule
    {
        
    }
}
