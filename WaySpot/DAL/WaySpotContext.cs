using WaySpot.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WaySpot.DAL
{
    public class WaySpotContext : DbContext
    {
        public WaySpotContext() : base("WaySpotContext")
        {
        }

        public DbSet<Hold> Holds { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}