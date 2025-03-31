using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Syrna.TemplateProject.MongoDB
{
    public class TemplateProjectMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public TemplateProjectMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}