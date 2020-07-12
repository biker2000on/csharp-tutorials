using Microsoft.EntityFrameworkCore;

namespace webApp.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (
            DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<webApp.Models.Movie> Movie { get; set; }
    }
}