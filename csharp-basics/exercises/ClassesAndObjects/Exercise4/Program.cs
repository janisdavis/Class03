using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie casinoRoyale = new Movie("Casino Royale", "Eon Productions", "PG13");
            Movie glass = new Movie("Glass", "Buena Vista International", "PG13");
            Movie spiderMan = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");

            Movie[] myArray = new Movie[3];

            myArray[0] = casinoRoyale;
            myArray[1] = glass;
            myArray[2] = spiderMan;

            var neededMovies = Movie.GetPG(myArray);

            foreach (var element in neededMovies)
            {
                if (element != null)
                {
                    Console.WriteLine(element._title.ToString());
                }
            }
            Console.ReadKey();
            }
        }
    }
    
