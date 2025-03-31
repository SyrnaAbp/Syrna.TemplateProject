using System;
using Volo.Abp.ObjectExtending.Modularity;

namespace Syrna.TemplateProject.ObjectExtending;

public class TemplateProjectModuleExtensionConfiguration : ModuleExtensionConfiguration
{
    public TemplateProjectModuleExtensionConfiguration ConfigurePrivateMessage(
        Action<EntityExtensionConfiguration> configureAction)
    {
        return this.ConfigureEntity(
            TemplateProjectModuleExtensionConsts.EntityNames.PrivateMessage,
            configureAction
        );
    }
}
