using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using webApp.Data;
using System;
using System.Linq;

namespace webApp.Models
{
  public static class SeedData
  {
    public static void Initialize(IServiceProvider serviceProvider)
    {
      using (var context = new RazorPagesMovieContext(
          serviceProvider.GetRequiredService<
              DbContextOptions<RazorPagesMovieContext>>()))
      {
        // Look for any movies.
        if (context.Movie.Any())
        {
          return;   // DB has been seeded
        }

        context.Movie.AddRange(
            new Movie
            {
              Title = "When Harry Met Sally",
              Date = DateTime.Parse("1989-2-12"),
              Genre = "Romantic Comedy",
              Price = 7.99M,
              Rating = "R"
            },

            new Movie
            {
              Title = "Ghostbusters ",
              Date = DateTime.Parse("1984-3-13"),
              Genre = "Comedy",
              Price = 8.99M,
              Rating = "PG-13"
            },

            new Movie
            {
              Title = "Ghostbusters 2",
              Date = DateTime.Parse("1986-2-23"),
              Genre = "Comedy",
              Price = 9.99M,
              Rating = "PG-13"
            },

            new Movie
            {
              Title = "Rio Bravo",
              Date = DateTime.Parse("1959-4-15"),
              Genre = "Western",
              Price = 3.99M,
              Rating = "G"
            }
        );
        context.SaveChanges();
      }
    }
  }
}