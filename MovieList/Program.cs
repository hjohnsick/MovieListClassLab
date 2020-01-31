using System;
using System.Collections.Generic;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> cinemaCarosel = new List<Movie>
            {
                new Movie ("Forrest Gump", "drama"),
                new Movie ("Breakfast at Tiffany's", "classic"),
                new Movie ("Billy Madison", "comedy"),
                new Movie ("Overboard", "comedy"),
                new Movie ("The Shining", "horror"),
                new Movie ("The Omen", "horror"),
                new Movie ("Cassablanca", "classic"),
                new Movie ("The Godfather", "drama"),
                new Movie ("Beauty and the Beast", "animated"),
                new Movie ("The Little Mermaid", "animated"),

            };
            bool resume = false;
            do
            {
                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine("There are 10 movies in this list.");
                Console.WriteLine("What category are you interested in, (type: drama, classic, comedy, horror, or animated?");
                string userInput = Console.ReadLine();

                foreach (var movie in cinemaCarosel)
                {

                    if (userInput == "drama")
                    {
                        if (movie.Category == "drama")
                        {
                            Console.WriteLine(movie.Title);
                        }

                    }

                    else if (userInput == "classic")
                    {
                        if (movie.Category == "classic")
                        {
                            Console.WriteLine(movie.Title);

                        }
                    }
                    else if (userInput == "comedy")
                    {
                        if (movie.Category == "comedy")
                        {
                            Console.WriteLine(movie.Title);

                        }
                    }
                    else if (userInput == "horror")
                    {
                        if (movie.Category == "horror")
                        {
                            Console.WriteLine(movie.Title);

                        }
                    }
                    else if (userInput == "animated")
                    {
                        if (movie.Category == "animated")
                        {
                            Console.WriteLine(movie.Title);
                        }
                    }
                    else
                    {
                        resume = AskToTryAgain(GetUserInput("Not a proper input. Try again? (y/n)"));
                    }
                }
                resume = AskToTryAgain(GetUserInput("Do you want to try again? (y/n)"));


            } while (resume == true);
            

            //Need to figure out how to get the movie titles into this code.

           // while(enterAgain == "y")
            //{

                
/*
                if (userInput == "drama")
                {
                    Movie.PrintMovieTitles(cinemaCarosel, "Forrest Gump");
                }
                else if (userInput == "classic")
                {
                    Movie.PrintMovieTitles(cinemaCarosel, "Breakfast at Tiffany's");
                }
                else if (userInput == "comedy")
                {
                    Movie.PrintMovieTitles(cinemaCarosel, "Billy Madison");
                }
                else if (userInput == "horror")
                {
                    Movie.PrintMovieTitles(cinemaCarosel, "The Shining");
                }
                else
                {
                    Movie.PrintMovieTitles(cinemaCarosel, "Beauty and the Beast");
                }


    */
           // }
            //Need help with looping the user input
            
           

            
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }

        public static bool AskToTryAgain(string input)
        {
            if (input[0] == 'y')
            {
                return true;
            }
            else if(input[0] == 'n')
            {
                return false;
            }
            return false;
        }
    }
}

