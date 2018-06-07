using System;
using System.Collections.Generic;

namespace MoviesNew
{
    public class Movie
    {
        public string title { get; set; }
        public double rating { get; set; }
        public decimal earnings { get; set; }
        public List<string> actors { get; set; }
        public List<Review> reviews { get; set; } 

        //public double rating
        //{
        //    get
        //    {
        //        return rating;
        //    }

        //    set
        //    {
        //        int calc = 0;
        //        foreach (var item in reviews)
        //        {
        //            calc += item.score;
        //        }
        //        rating = calc / reviews.Count;
        //    }
        //}

        public static double CalcRating(List<Review> reviews)
        {
            double calc = 0;
            foreach (var item in reviews)
            {
                calc += item.score;
            }
            return calc / reviews.Count;
        }

        public static List<string> Actors()
        {
            var movieActors = new List<string>();

            for (int i = 0; i < 20; i++)
            {
                movieActors.Add("Actor " + i);
            }
            return movieActors;
        }

        public static List<Review> GiveReviews()
        {
            var movieReviews = new List<Review>();
            Random ratemovie = new Random();

            for (int i = 0; i< 5; i++)
            {
                var review = new Review()
                {
                    score = ratemovie.Next(1, 11),
                    comment = "lala Review" + i
                };
            movieReviews.Add(review);
            }

           // CalcRating(movieReviews);
            return movieReviews;
        }

        public static void PrintMovies(List<Movie> movies)
        {
            foreach (var item in movies)
            {
                Console.WriteLine($"Title: {item.title}");
                Console.WriteLine($"Earnings: {item.earnings} $");
                Console.WriteLine($"Rating: {item.rating}");

                Console.WriteLine();
            }
        }
    }
}
