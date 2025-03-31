using System.Threading.Tasks;
using Syrna.TemplateProject.Authorization;
using Syrna.TemplateProject.Localization;
using Volo.Abp.UI.Navigation;

namespace Syrna.TemplateProject.Web.Menus;

public class TemplateProjectMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var l = context.GetLocalizer<TemplateProjectResource>();
        //Add main menu items.

        if (await context.IsGrantedAsync(TemplateProjectPermissions.PrivateMessages.Default))
        {
            context.Menu.GetAdministration().AddItem(new ApplicationMenuItem(TemplateProjectMenus.Prefix,
                displayName: l["Menu:PrivateMessage"], "~/TemplateProject/PrivateMessages/PrivateMessage", icon: "fa fa-messages"));
        }
    }
}