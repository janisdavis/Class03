using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Input number to multiply : ");

            int result = Convert.ToInt32(Console.ReadLine());
            int multiply = result;
            
            for (int i= 1; i< multiply; i++)
            {
                result *= multiply;
            }


            Console.WriteLine($"{result}");
            Console.ReadKey();

        }
    }
}
