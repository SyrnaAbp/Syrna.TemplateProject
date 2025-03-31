using System.Threading.Tasks;
using Syrna.TemplateProject.Authorization;
using Volo.Abp.AspNetCore.Components.Web.Theming.Toolbars;

namespace Syrna.TemplateProject.Blazor
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