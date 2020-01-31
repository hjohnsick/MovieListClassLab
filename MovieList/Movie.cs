using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList
{
    class Movie
    {
        private string title;
        private string category;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public Movie()
        {

        }
        public Movie(string _title, string _category)
        {
            title = _title;
            category = _category;
        }
        private static List<string>GetListOfMovies(List<Movie>movieList)
        {
            List<string> movieTitles = new List<string>();
            foreach (Movie selection in movieList)
            {
                if (!movieTitles.Contains(selection.Title))
                {
                    movieTitles.Add(selection.Title);
                }
            }
            return movieTitles;
        }

        public static void PrintMovieTitles(List<Movie> movieList)
        {
            List<string> movieTitles = GetListOfMovies(movieList);
            foreach(string movie in movieTitles)
            {
                Console.Write($"{movie}, ");
            }
            Console.WriteLine();
        }
        public static void PrintMovieTitles(List<Movie> movieList, string titleSelected)
        {
            foreach(Movie movie in movieList)
            {
                if(titleSelected == movie.title )
                {
                    Console.WriteLine($"{movie.title}");
                }
            }
        }
        

    }

}
