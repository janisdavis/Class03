using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for ( int i=1; i<=number; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                else if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.Write("FizzBuzz");
                }
                else
                {
                    Console.Write(i);
                }
                Console.Write(" ");
                if (i % 20 == 0) 
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
