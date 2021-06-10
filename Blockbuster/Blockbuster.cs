using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    class Blockbuster
    {
        List<Movie> Movies = new List<Movie>();

        public Blockbuster(List<Movie> Movies)
        {
            this.Movies = Movies;
        }
        public Movie PrintMovies(List<Movie> Movies)
        {
            Console.WriteLine("Here is the list of movies");
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine(i + ": " + Movies[i].Title);
            }
            Console.WriteLine("Please select a movie by index");
            string input = Console.ReadLine();
            int index = int.Parse(input);
            Movies[index].PrintInfo();
            return Movies[index];
        }
    }


}
