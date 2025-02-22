using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Mission06_Hair.Models
{
    public class NewMovieContext : DbContext
    {
        public NewMovieContext(DbContextOptions<NewMovieContext> options) : base (options) 
        {
        }

        public DbSet<NewMovie> NewMovies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { CategoryId = 1, CategoryName = "Drama"},
                new Category { CategoryId = 2, CategoryName = "Television" },
                new Category { CategoryId = 3, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 4, CategoryName = "Comedy" },
                new Category { CategoryId = 5, CategoryName = "Family" },
                new Category { CategoryId = 6, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 7, CategoryName = "VHS" },
                new Category { CategoryId = 8, CategoryName = "Miscellaneous" }


             );
        }
    }
}
