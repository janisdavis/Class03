using System;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());


            for (int i = minNumber; i <= maxNumber; i++)
            {

                for (int j = 0; j <= maxNumber - minNumber; j++)
                {
                    var value = i + j;

                    if (value > maxNumber)
                    {
                        value = j + i - maxNumber + minNumber - 1;
                    }
                    Console.Write(value + " ");
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
