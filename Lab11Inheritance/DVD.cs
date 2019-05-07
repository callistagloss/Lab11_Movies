using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11Inheritance
{
    class DVD : Movie
    {
        public DVD(string Title, string Category, int RunTime, List<string> Scenes) 
            : base(Title, Category, RunTime, Scenes)
            //base invokes the parent's constructor
        {

        }
        public override void Play()
        {
            PrintScenes();
            Console.WriteLine("What scene would you like to see?");
            string input = Console.ReadLine();
            int index = int.Parse(input); //picking scene from index
            string scene = Scenes[index];
            Console.WriteLine(scene);

        }
    }
}
