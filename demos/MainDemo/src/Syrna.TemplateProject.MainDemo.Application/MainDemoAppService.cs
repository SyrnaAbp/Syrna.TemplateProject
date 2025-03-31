using Syrna.TemplateProject.MainDemo.Localization;
using Volo.Abp.Application.Services;

namespace Syrna.TemplateProject.MainDemo;

/* Inherit your application services from this class.
 */
public abstract class MainDemoAppService : ApplicationService
{
    protected MainDemoAppService()
    {
        LocalizationResource = typeof(MainDemoResource);
    }
}
