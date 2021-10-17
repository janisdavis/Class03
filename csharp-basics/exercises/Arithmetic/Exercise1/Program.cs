using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input first integer!");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input second integer!");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            bool lookingFor15()
            {
                return numOne == 15 || numTwo == 15 || numOne + numTwo == 15 || numOne - numTwo == 15 || numTwo - numOne == 15;
            }
            Console.WriteLine(lookingFor15());
            Console.ReadKey();
        }
    }
}
