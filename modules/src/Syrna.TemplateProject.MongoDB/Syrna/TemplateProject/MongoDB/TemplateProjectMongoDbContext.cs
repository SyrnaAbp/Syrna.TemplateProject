using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Syrna.TemplateProject.MongoDB
{
    [ConnectionStringName(TemplateProjectDbProperties.ConnectionStringName)]
    public class TemplateProjectMongoDbContext : AbpMongoDbContext, ITemplateProjectMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureTemplateProject();
        }
    }
}