using Syrna.TemplateProject.MainDemo;
using Syrna.TemplateProject.MainDemo.Localization;
using Volo.Abp.Application.Services;

namespace Syrna.TemplateProject.MainDemo.SettingManagement;

public abstract class SettingManagementAppServiceBase : ApplicationService
{
    protected SettingManagementAppServiceBase()
    {
        ObjectMapperContext = typeof(MainDemoApplicationModule);
        LocalizationResource = typeof(MainDemoResource);
    }
}
