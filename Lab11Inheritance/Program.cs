using System;
using System.Text;
using System.Collections.Generic;

namespace Lab11Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster b = new Blockbuster(); //Blockbuster constructor
            b.CheckOut();
            b.PrintMovies();
            

           
            //List<string> Scenes = new List<string>() { "Capture Vespa", "Blow up deathstar", "Pizza the hutt" };
            //Movie m = new Movie("Space Balls", "Comedy", 120, Scenes);
            //m.PrintInfo();
            //m.Play();
            //Console.WriteLine();

            //List<string> Scenes2 = new List<string>() { "Cantina Scene", "Jefferson Starship", "Bobba Fett Cartoon" };
            //DVD d = new DVD("Star Wars Holiday Special", "Hot Mess", 80, Scenes2);
            //d.PrintInfo();
            //d.Play();
            //Console.WriteLine();


        }
    }
}
