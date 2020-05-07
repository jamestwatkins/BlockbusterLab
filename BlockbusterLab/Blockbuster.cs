using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class Blockbuster
    {
        private List<Movie> movies = new List<Movie>() { };
        public List<Movie> Movies { get; set; }

       
        
      
        

        public Blockbuster()
        {
            movies = new List<Movie>();

            movies.Add(new DVD("Shrek", 98, Genres.Comedy, new List<string>() { "All-Star Scene", "Shrek Meets Donkey", "Shrek Wins the Tournement", "Shrek Rescues Fionba", "Shrek and Fionna Kiss" }));
            movies.Add(new DVD("Shawshank Redemption", 134, Genres.Drama, new List<string>() { "Andy Gets Arrested", "Andy Gets Admitted to Shawshank", "Andy Gets the Rock Hammer from Red", "Andy Escapes", "Red Reunites with Andy" }));
            movies.Add(new DVD("Ender's Game", 122, Genres.Action, new List<string>() { "Ender Kills the Bully", "Ender Gets Selected for Battle School", "Ender's Team Wins in the Battle Arena", "Ender Defeats the Aliens", "Ender Finds the Alien Egg" }));
            movies.Add(new VHS("Star Wars", 111, Genres.Action, new List<string>() { "Luke Meets Ben Kenobi", "The Millenium Falcon Escapes Empirial Forces", "The Death Star Destroys Alderan", "The Group Saves the Princess", "Luke Destroys the Death Star" }));
            movies.Add(new VHS("Oliver and Company", 90, Genres.Family, new List<string>() { "Oliver is Abandoned", "Oliver Meets the Dogs", "Oliver Gets Found by Jenny", "The Dogs Rescue Oliver","The Train Scene" }));
            movies.Add(new VHS("50 First Dates", 90, Genres.Romance, new List<string>() { "They Meet", "Adam Learns of Her Condition","The Dates","She Gets Admitted to the Clinic","They Get Married" }));


        }

        public void PrintMovies()
        {
            foreach (Movie movie in movies)
            {
                Console.WriteLine($"{movies.IndexOf(movie) + 1}. {movie.Title}");
            }
        }

        public void CheckOut()
        {
            PrintMovies();
            Console.WriteLine();

            Console.WriteLine("Which movie would you like to check out?");

            int movieIndex = 0;

            while (true)
            {

                string input = Console.ReadLine();
                Console.WriteLine();


                bool isNum = int.TryParse(input, out movieIndex);

                if (isNum)
                {
                    try
                    {
                        movies[movieIndex - 1].PrintInfo();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("That was not a valid movie index, please try again:");
                        continue;

                    }
                }
                else
                {
                    Console.WriteLine("That was not a valid movie index, please try again:");
                    continue;
                }
            }

            Console.WriteLine();

            Console.WriteLine("Would you like to watch this movie? y to watch movie, any other key to go back to the menue.");

            string response = Console.ReadLine();

            if(response == "y")
            {
                movies[movieIndex - 1].Play();
            }


        }
    }

       

           
    
}
