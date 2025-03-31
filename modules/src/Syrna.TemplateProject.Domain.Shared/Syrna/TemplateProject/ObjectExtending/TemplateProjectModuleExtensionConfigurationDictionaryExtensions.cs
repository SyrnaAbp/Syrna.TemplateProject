using System;
using Volo.Abp.ObjectExtending.Modularity;

namespace Syrna.TemplateProject.ObjectExtending;

public static class TemplateProjectModuleExtensionConfigurationDictionaryExtensions
{
    public static ModuleExtensionConfigurationDictionary ConfigureTemplateProject(
        this ModuleExtensionConfigurationDictionary modules,
        Action<TemplateProjectModuleExtensionConfiguration> configureAction)
    {
        return modules.ConfigureModule(
            TemplateProjectModuleExtensionConsts.ModuleName,
            configureAction
        );
    }
}
