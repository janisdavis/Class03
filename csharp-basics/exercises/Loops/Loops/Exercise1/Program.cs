using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The first 10 natural numbers are: ");
            for (int i = 0; i < 10; i++)
            {
                NaturalNumbers(i);

            }
            Console.ReadKey();

        }
        static void NaturalNumbers(int num)
            {
                Console.Write($"{num}");
            }

        
    }
}
