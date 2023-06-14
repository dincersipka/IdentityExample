using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace IdentityExample.Persistence.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ApplicationDbContext> Builder = new DbContextOptionsBuilder<ApplicationDbContext>();

            Builder.UseSqlServer(Configuration.MigrationString);

            return new(Builder.Options);
        }
    }
}
