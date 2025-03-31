using Syrna.TemplateProject;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.Account;
using Volo.Abp.Identity;
using Volo.Abp.PermissionManagement;

namespace Syrna.TemplateProject.MainDemo;

[DependsOn(typeof(AbpObjectExtendingModule))]
[DependsOn(typeof(AbpAccountApplicationContractsModule))]
[DependsOn(typeof(AbpFeatureManagementApplicationContractsModule))]
[DependsOn(typeof(AbpIdentityApplicationContractsModule))]
[DependsOn(typeof(AbpPermissionManagementApplicationContractsModule))]
[DependsOn(typeof(AbpSettingManagementApplicationContractsModule))]
[DependsOn(typeof(AbpTenantManagementApplicationContractsModule))]
//app modules
[DependsOn(typeof(MainDemoDomainSharedModule))]

[DependsOn(typeof(TemplateProjectApplicationContractsModule))]
public class MainDemoApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        MainDemoDtoExtensions.Configure();
    }
}
