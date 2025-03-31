using Syrna.TemplateProject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Syrna.TemplateProject.Authorization
{
    public class TemplateProjectPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var moduleGroup = context.AddGroup(TemplateProjectPermissions.GroupName, L("Permission:TemplateProject"));
            
            var privateMessages = moduleGroup.AddPermission(TemplateProjectPermissions.PrivateMessages.Default, L("Permission:PrivateMessage"));
            privateMessages.AddChild(TemplateProjectPermissions.PrivateMessages.Create, L("Permission:Create"));
            privateMessages.AddChild(TemplateProjectPermissions.PrivateMessages.SetRead, L("Permission:SetRead"));
            privateMessages.AddChild(TemplateProjectPermissions.PrivateMessages.Delete, L("Permission:Delete"));
            
            var privateMessageNotifications = moduleGroup.AddPermission(TemplateProjectPermissions.PrivateMessageNotifications.Default, L("Permission:PrivateMessageNotification"));
            privateMessageNotifications.AddChild(TemplateProjectPermissions.PrivateMessageNotifications.Delete, L("Permission:Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<TemplateProjectResource>(name);
        }
    }
}