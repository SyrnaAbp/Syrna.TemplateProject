using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Syrna.TemplateProject.EntityFrameworkCore
{
    [ConnectionStringName(TemplateProjectDbProperties.ConnectionStringName)]
    public interface ITemplateProjectDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}
