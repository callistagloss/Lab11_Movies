using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11Inheritance
{
    class Blockbuster
    {
       public List<Movie> Movies {get; set;}

        public static List<Movie> Movies = new List<Movie>();

        public Blockbuster() //constructor
        {
            Movies = new List<Movie>();
            List<string> DumbScenes = new List<string>() {"swindle blind kid", "kill gas man", "buy leisure suits"};
            VHS dumbDumber = new VHS("Dumb and Dumber", "Comedy", 120, DumbScenes);
            Movies.Add(dumbDumber);

            Movies = new List<Movie>();
            List<string> HangoverScenes= new List<string>() {"Tiger and Mike Tyson scene", "Drink a lot", "Find Doug on roof"};
            VHS Hangover = new VHS("The Hangover", "Comedy", 120, HangoverScenes);
            Movies.Add(Hangover);

            Movies = new List<Movie>();
            List<string> FindingNemoScenes = new List<string>() {"Nemo gets stolen", "Jellyfish", "Dentist scenes"};
            DVD FindingNemo = new DVD("Finding Nemo", "Disney", 90, FindingNemoScenes);
            Movies.Add(FindingNemo);

            Movies = new List<Movie>();
            List<string> FrozenScenes = new List<string>() {"Wanna build a snowman", "ice stuff", "snow"};
            DVD Frozen = new DVD("Dumb and Dumber", "Disney", 90, FrozenScenes);
            Movies.Add(FrozenScenes);



            List<string> Scenes = new List<string>() { "Jefferson Starship", "Boba Fett Cartoon", "Cantina Scene", "Lumpy Playing with Bantha" };
            VHS vhs0 = new VHS("Star Wars Holiday Special", "HotMess", 90, Scenes);
            Movies.Add(vhs0);
            Console.WriteLine();

            List<string> Scenes1 = new List<string>() { "Capture Vespa", "Blow up deathstar", "Pizza the hutt", "Fly spaceship" };
            VHS vhs1 = new VHS("SpaceBalls", "Comedy", 120, Scenes1);
            Movies.Add(vhs1);
            Console.WriteLine();

            List<string> Scenes2 = new List<string>() { "Steal Death Star plans", "Watch dad die", "Grand Moff Tarkin CGI", "Princess Leia CGI" };
            VHS vhs2 = new VHS("Rogue One", "SciFi", 140, Scenes2);
            Movies.Add(vhs2);
            Console.WriteLine();

            List<string> Scenes3 = new List<string>() { "Boromir Dies", "Arwen in the river", "Strider at the inn", "Sam eavesdropping on Frodo" };
            DVD dvd0 = new DVD("Fellowship of the Ring", "Fantasy", 180, Scenes3);
            Movies.Add(dvd0);
            Console.WriteLine();

            List<string> Scenes4 = new List<string>() { "Legolas and Aragorn and Gimli running", "Merry and Pippin with the ents", "Gollum leading Sam and Frodo", "Arwen and Aragorn's dream scene" };
            DVD dvd1 = new DVD("The Two Towers", "Fantasy", 180, Scenes4);
            Movies.Add(dvd1);
            Console.WriteLine();

            List<string> Scenes5 = new List<String>() { "The dead marshes", "Battle at Gondor", "Aragorn's Coronation", "Elves leaving Middle-Earth" };
            DVD dvd2 = new DVD("Return of the King", "Fantasy", 210, Scenes5);
            Movies.Add(dvd2);
            Console.WriteLine();

        }

        public void PrintMovies()
        {
            
            for (int i = 0; i < Movies.Count; i++)
            {
                //Movie m = Movies[i]; Tommy's code 
                Console.WriteLine($"{i} : {Movies[i].Title}" );
            }
            
            //this will print all the movie titles in the Movies list along with their indexes.
        }

        public void CheckOut()
        {
            Console.WriteLine("Please select an index from the following list: ");
            PrintMovies();
            string input = (Console.ReadLine());
            int index = int.Parse(input);
            Movies[index].PrintInfo(); //do this instead of if statements because of the for loop in PrintMovies
                
            //Movie m = Movies[index];    Tommy's code
            //m.PrintInfo();
            //m.Play();


            //if (index == 0)
                //    {
                //    Console.WriteLine(0);
                //    }
                //    if (index == 1)
                //    {
                //    Console.WriteLine(1);
                //    }
                //    if (index == 2)
                //    {
                //    Console.WriteLine(2);
                //    }
                //    if (index == 3)
                //    {
                //    Console.WriteLine(3);
                //    }
                //    if (index == 4)
                //    {
                //    Console.WriteLine(4);
                //    }
                //    if (index == 5)
                //    {
                //    Console.WriteLine(5);
                //    }
                //    else
                //    {
                //    Console.WriteLine("I'm sorry. I didn't understand your input. Please try again.");
                //    }
        

            //Play();
            //4. use inputted index to grab a movie from the list
            //5. play movie
        }
    }
}
