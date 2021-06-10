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

        public Movie(string title, Genre category, int runtime, List<string> scenes)
        {
            Title = title;
            Category = category;
            RunTime = runtime;
            Scenes = scenes;
        }

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

    class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;
        public VHS(string title, Genre category, int runtime, List<string> scenes) 
            : base(title, category, runtime, scenes)
        {
        }

        
        public override void Play()
        {
            Console.WriteLine("Playing current scene");
            CurrentTime++;
        }

        public void Rewind()
        {
            CurrentTime = 0;
            Console.WriteLine("Your VHS has been rewound");
        }
    }

    class DVD : Movie
    {
        public DVD(string title, Genre category, int runtime, List<string> scenes) 
            : base(title, category, runtime, scenes)
        {
        }

        public override void Play()
        {
            Console.WriteLine("What scene would you like to watch?");
            foreach(string scene in Scenes)
            {
                Console.WriteLine(scene);
            }
            string input = Console.ReadLine();
            Console.WriteLine($"Now watching scene: " + input);
        }
    }
}
