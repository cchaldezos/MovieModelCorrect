using System;
using System.Collections.Generic;
using System.Linq;

namespace MoviesNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rate = new Random();
            var movies = new List<Movie>();

            for (int i = 0; i < 30; i++)
            {
                var movie = new Movie()
                {
                    title = "Movie - " + i,
                    earnings = rate.Next(6000000, 10000000) * i,
                    reviews = Movie.GiveReviews(),
                    actors = Movie.Actors()
                };
                movies.Add(movie);
            }

            foreach (var item in movies)
            {
                item.rating = Movie.CalcRating(item.reviews);
            }

            Console.WriteLine("Top 10 Movies with best rating:\n");
            
            // Sort movies by rating
            var sortedMovies = movies.OrderBy(s => s.rating).ToList();
            // Reverse list
            sortedMovies.Reverse();
            // Take asked movies
            var best10Movies = sortedMovies.Take(10).ToList();

            Movie.PrintMovies(best10Movies);

            Console.ReadKey();
        }
    }
}
