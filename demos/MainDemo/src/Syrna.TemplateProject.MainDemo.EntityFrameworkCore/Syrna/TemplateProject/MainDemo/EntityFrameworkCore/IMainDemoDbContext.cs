using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Syrna.TemplateProject;

namespace Syrna.TemplateProject.MainDemo.EntityFrameworkCore
{
    [ConnectionStringName(TemplateProjectDbProperties.ConnectionStringName)]
    public interface IMainDemoDbContext : IEfCoreDbContext
    {
    }
}
