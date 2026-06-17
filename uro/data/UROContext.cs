using Microsoft.EntityFrameworkCore;
using uro.models;

namespace uro.data
{
    public class UROContext : DbContext
    {
        public UROContext(DbContextOptions<UROContext> options) : base(options)
        { }

        public DbSet<AlighnedCountrysModel> AlighnedCountrys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AlighnedCountrysModel>().ToTable("AlighnedCountrys");
        }
    }
}
