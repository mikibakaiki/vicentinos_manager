using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Presence> Presences { get; set; }
        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Presence>().Property<int>("FamilyId");
            modelBuilder.Entity<Presence>().HasOne(p => p.Family).WithMany(f => f.Presences).HasForeignKey("FamilyId").IsRequired(true).OnDelete(DeleteBehavior.Restrict);
        }


    }
}