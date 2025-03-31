using Syrna.TemplateProject.Localization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Syrna.TemplateProject
{
    [Area(TemplateProjectRemoteServiceConsts.ModuleName)]
    public abstract class TemplateProjectController : AbpController
    {
        protected TemplateProjectController()
        {
            LocalizationResource = typeof(TemplateProjectResource);
        }
    }
}
