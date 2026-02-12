using HousingSocietyApi.DataModel.Tables;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ServiceManagement.Infrastructure.DB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<account_grp_mst> account_grp_mst { get; set; }
        public DbSet<install_mst> install_mst { get; set; }
        public DbSet<society_ms> society_mst { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
