using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Syrna.TemplateProject.EntityFrameworkCore
{
    public class TemplateProjectModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public TemplateProjectModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}