using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int randomNumber;
            Random rand = new Random();
            randomNumber = rand.Next(1, 101);
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            Console.Write("Enter a number:");

            num = Convert.ToInt32(Console.ReadLine());
            
            while (num> 100 || num <0)
            {
                Console.WriteLine("Your number is out of scope. Enter a number between 1-100");
                num = Convert.ToInt32(Console.ReadLine());
            }
            
            
            if (num < randomNumber)
            {
                Console.WriteLine($"Sorry, you are too low.  I was thinking of {randomNumber}.");
            }
            else if (num > randomNumber)
            {
              Console.WriteLine($"Sorry, you are too high.  I was thinking of {randomNumber}");
            }
            else
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");
            }
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }
    }
}
