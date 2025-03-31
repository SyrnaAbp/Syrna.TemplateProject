using Syrna.TemplateProject.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Syrna.TemplateProject.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class TemplateProjectPageModel : AbpPageModel
    {
        protected TemplateProjectPageModel()
        {
            LocalizationResourceType = typeof(TemplateProjectResource);
            ObjectMapperContext = typeof(TemplateProjectWebModule);
        }
    }
}