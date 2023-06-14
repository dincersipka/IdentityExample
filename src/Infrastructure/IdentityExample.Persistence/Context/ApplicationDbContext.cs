using IdentityExample.Application.Abstractions.Context;
using IdentityExample.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IdentityExample.Persistence.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> Options) : base(Options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role() 
            {
                Id = Guid.Parse("77A61B7A-1590-4DEF-A0FB-4D3946C9CEE4"),
                Name = "Admin",
                CreatedBy = "SeedData"
            });

            modelBuilder.Entity<User>().HasData(new User() 
            {
                FirstName = "Dinçer",
                LastName = "Şipka",
                Username = "dincersipka",
                Password = "1",
                RoleId = Guid.Parse("77A61B7A-1590-4DEF-A0FB-4D3946C9CEE4"),
                CreatedBy = "SeedData"
            });
        }
    }
}
