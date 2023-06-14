using Microsoft.Extensions.Configuration;

namespace IdentityExample.Persistence
{
    static class Configuration
    {
        public static string? MigrationString
        {
            get
            {
                ConfigurationManager Configuration = new ConfigurationManager();

                Configuration.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/Api/IdentityExample.WebApi"));
                Configuration.AddJsonFile("appsettings.json");

                return Configuration.GetConnectionString("SqlServer");
            }
        }

        public static string? ConnectionString
        {
            get
            {
                ConfigurationManager Configuration = new ConfigurationManager();

                Configuration.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../IdentityExample.WebApi"));
                Configuration.AddJsonFile("appsettings.json");

                return Configuration.GetConnectionString("SqlServer");
            }
        }
    }
}
