using System;
using System.Collections.Generic;

namespace Blockbuster
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            List<Movie> offerings = new List<Movie>();
            List<string> scenes1 = new List<string> { "beginning", "middle", "end" };
            List<string> scenes2 = new List<string> { "beginning", "middle", "end" };
            List<string> scenes3 = new List<string> { "beginning", "middle", "end" };
            List<string> scenes4 = new List<string> { "beginning", "middle", "end" };
            List<string> scenes5 = new List<string> { "beginning", "middle", "end" };
            List<string> scenes6 = new List<string> { "beginning", "middle", "end" };
            VHS v1 = new VHS("After", Genre.Romance, 120, scenes1);
            VHS v2 = new VHS("1917", Genre.Action, 150, scenes2);
            VHS v3 = new VHS("Dumb and Dumber", Genre.Comedy, 99, scenes3);
            DVD d1 = new DVD("Sideways", Genre.Comedy, 135, scenes4);
            DVD d2 = new DVD("Zoolander", Genre.Comedy, 98, scenes5);
            DVD d3 = new DVD("High Noon", Genre.Drama, 78, scenes6);

            offerings.Add(v1);
            offerings.Add(v2);
            offerings.Add(v3);
            offerings.Add(d1);
            offerings.Add(d2);
            offerings.Add(d3);
            Blockbuster myVideoStore = new Blockbuster(offerings);

            myVideoStore.PrintMovies(offerings);
        }
    }
}
