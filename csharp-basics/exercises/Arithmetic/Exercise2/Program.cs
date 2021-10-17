using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number:");
            num = Convert.ToInt32( Console.ReadLine());
            
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }
    }
}
