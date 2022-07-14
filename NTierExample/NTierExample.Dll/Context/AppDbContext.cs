using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NTierExample.Dll.Entities;

namespace NTierExample.Dll.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Activity> Activities { get; set; } = null!;
        public DbSet<Log> Logs { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>().HasData(new Activity() 
            {
                Id = 1,
                CreatedBy = "Triss",
                CreationDate = DateTime.Now,
                ModifiedBy = "",
                Name = "Spell"
            });
        }

    }
}
