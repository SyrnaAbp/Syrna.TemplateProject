using Syrna.TemplateProject.Localization;
using Volo.Abp.Application.Services;

namespace Syrna.TemplateProject
{
    public abstract class TemplateProjectAppService : ApplicationService
    {
        protected TemplateProjectAppService()
        {
            LocalizationResource = typeof(TemplateProjectResource);
            ObjectMapperContext = typeof(TemplateProjectApplicationModule);
        }
    }
}
