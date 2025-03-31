using Syrna.TemplateProject.MainDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Syrna.TemplateProject.MainDemo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MainDemoController : AbpControllerBase
{
    protected MainDemoController()
    {
        LocalizationResource = typeof(MainDemoResource);
    }
}
