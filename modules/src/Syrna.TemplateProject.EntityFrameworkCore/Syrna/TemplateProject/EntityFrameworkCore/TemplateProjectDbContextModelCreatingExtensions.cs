using Microsoft.EntityFrameworkCore;
using System;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Syrna.TemplateProject.EntityFrameworkCore
{
    public static class TemplateProjectDbContextModelCreatingExtensions
    {
        public static void ConfigureTemplateProject(
            this ModelBuilder builder,
            Action<TemplateProjectModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new TemplateProjectModelBuilderConfigurationOptions(
                TemplateProjectDbProperties.DbTablePrefix,
                TemplateProjectDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

        }
    }
}
