using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Syrna.TemplateProject.MongoDB
{
    [ConnectionStringName(TemplateProjectDbProperties.ConnectionStringName)]
    public interface ITemplateProjectMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
