using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11Inheritance
{
    class Movie
    {
        public string Title { get; set; } //properties can be called/used like methods, ie. m.Title();
        public string Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string Title, string Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Movie info: ");
            Console.WriteLine(Title);
            Console.WriteLine(Category);
            Console.WriteLine(RunTime);
            PrintScenes();
        }

        public void PrintScenes()
        {
            for(int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scence {i}: {Scenes[i]}");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine("The play method only works on physical media.");
        }

        public virtual void Rewind()
        {

        }


    }


}
   
        


