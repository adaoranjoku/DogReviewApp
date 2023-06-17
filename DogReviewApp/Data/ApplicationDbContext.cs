using DogReviewApp.Models;
using Microsoft.EntityFrameworkCore;
namespace DogReviewApp.Data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<DogCategory> DogCategories { get; set; }
        public DbSet<DogOwner> DogOwners { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DogCategory>()
                .HasKey(dc => new { dc.DogId, dc.CategoryId });
            modelBuilder.Entity<DogCategory>()
                .HasOne(d => d.Dog)
                .WithMany(dc => dc.DogCategories)
                .HasForeignKey(d => d.DogId);
            modelBuilder.Entity<DogCategory>()
                .HasOne(c => c.Category)
                .WithMany(dc => dc.DogCategories)
                .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<DogOwner>()
                .HasKey(dOwner => new { dOwner.DogId, dOwner.OwnerId });
            modelBuilder.Entity<DogOwner>()
                .HasOne(d => d.Dog)
                .WithMany(dOwner => dOwner.DogOwners)
                .HasForeignKey(d => d.DogId);
            modelBuilder.Entity<DogOwner>()
                .HasOne(p => p.Owner)
                .WithMany(dc => dc.DogOwners)
                .HasForeignKey(c => c.OwnerId);
        }
    }
}