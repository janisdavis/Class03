using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The first 10 natural numbers are: ");
            for (int i = 1; i < 11; i++)
            {
                naturalNumbers(i);

            }
            Console.ReadKey();

        }
        static void naturalNumbers(int num)
            {
                Console.Write($"{num}");
            }

        
    }
}
