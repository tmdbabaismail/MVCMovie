using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MVCMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MVCMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Ninja Turtles",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Action",
                    Rating = "A",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Enter the new dragon ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Action",
                    Rating = "S",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Inception",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Adventure/Sci-Fi",
                    Rating = "S",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Donie Darko",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Fantasy",
                    Rating = "S",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Sparan",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "History",
                    Rating = "S",
                    Price = 3.99M
                }
         );
            context.SaveChanges();
        }
    }
}