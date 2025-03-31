using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Syrna.TemplateProject.MainDemo.EntityFrameworkCore;

public class MainDemoModelBuilderConfigurationOptions(
   [NotNull] string tablePrefix = "",
   [CanBeNull] string schema = null) : AbpModelBuilderConfigurationOptions(
       tablePrefix,
       schema)
{
}
