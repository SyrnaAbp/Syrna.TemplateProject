using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Syrna.TemplateProject.MongoDB
{
    public static class TemplateProjectMongoDbContextExtensions
    {
        public static void ConfigureTemplateProject(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new TemplateProjectMongoModelBuilderConfigurationOptions(
                TemplateProjectDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}