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
    }
}
