using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11Inheritance
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        //constructor
        public VHS(string Title, string Category, int RunTime, List<string> Scenes)
          : base(Title, Category, RunTime, Scenes)
        {
            CurrentTime = 0;
        }
        public override void Play()
        {
            if (CurrentTime < Scenes.Count)
            {
            string s = Scenes[CurrentTime];
            Console.WriteLine(s);
            CurrentTime++;
            }
            else
            {
                Rewind();
            }
            //A method called Play() that plays the scene at the current time and then increments CurrentTime. 

        }
        public void Rewind()
        {
            Console.WriteLine("Movie done! Rewind it.");
            CurrentTime = 0;
        }
    }
}
