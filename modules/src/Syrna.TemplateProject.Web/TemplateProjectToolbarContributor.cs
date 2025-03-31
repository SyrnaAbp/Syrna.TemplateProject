using Syrna.TemplateProject.Authorization;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;

namespace Syrna.TemplateProject.Web
{
    public class TemplateProjectToolbarContributor : IToolbarContributor
    {
        public virtual async Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
        {
            if (context.Toolbar.Name != StandardToolbars.Main)
            {
                return;
            }

            if (await context.IsGrantedAsync(
                TemplateProjectPermissions.PrivateMessageNotifications.Default))
            {
                //context.Toolbar.Items.Insert(0, new ToolbarItem(typeof(PmNotificationViewComponent)));
            }
        }
    }
}