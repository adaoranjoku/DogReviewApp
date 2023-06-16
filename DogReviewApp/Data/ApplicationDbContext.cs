using DogReviewApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace DogReviewApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
           
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

    }

}