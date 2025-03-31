using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Syrna.TemplateProject.EntityFrameworkCore
{
    [ConnectionStringName(TemplateProjectDbProperties.ConnectionStringName)]
    public class TemplateProjectDbContext : AbpDbContext<TemplateProjectDbContext>, ITemplateProjectDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public TemplateProjectDbContext(DbContextOptions<TemplateProjectDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureTemplateProject();
        }
    }
}
