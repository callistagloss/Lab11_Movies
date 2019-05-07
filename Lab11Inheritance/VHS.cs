using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11Inheritance
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(string Title, string Category, int RunTime, List<string> Scenes)
          : base(Title, Category, RunTime, Scenes)
        {
            CurrentTime = 0;
        }
        public override void Play()
        {
            string sc = Scenes[CurrentTime];
            CurrentTime++;
            //A method called Play() that plays the scene at the current time and then increments CurrentTime. 

        }
        public override void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
