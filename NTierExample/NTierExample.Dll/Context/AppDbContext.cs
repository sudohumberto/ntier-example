using Microsoft.EntityFrameworkCore;
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

    }
}
