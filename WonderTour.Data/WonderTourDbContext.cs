using Microsoft.EntityFrameworkCore;
using WonderTour.Data.Models;

namespace WonderTour.Data
{
    public class WonderTourDbContext : DbContext
    {
        public WonderTourDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Tour> Tours { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(WonderTourDbContext).Assembly);
        }
    }
}
