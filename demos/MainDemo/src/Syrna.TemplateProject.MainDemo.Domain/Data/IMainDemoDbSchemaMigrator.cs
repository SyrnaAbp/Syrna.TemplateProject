using System.Threading.Tasks;

namespace Syrna.TemplateProject.MainDemo.Data;

public interface IMainDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
