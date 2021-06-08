using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    public enum Genre
    {
        Drama,
        Comedy,
        Horror,
        Romance,
        Action
    }
    
    class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}; Genre: {Category}; Run Time: {RunTime}");
        }
        public virtual void PrintScenes()
        {
            for(int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine(Scenes[i]);
            }
        }

        public virtual void Play()
        {

        }
    }
}
