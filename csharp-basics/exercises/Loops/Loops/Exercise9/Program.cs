using System;

namespace Exercise9
{
    class ProgramRollTwoDice
    {
        static void Main(string[] args)
        {
            int desiredNumber;
            do
            {
                Console.Write("Desired sum (from 2 to 12): ");
                desiredNumber = Convert.ToInt32(Console.ReadLine());
                if (desiredNumber < 2 | desiredNumber > 12)
                    Console.WriteLine("Please enter a valid number!\n");
            } while (desiredNumber < 2 | desiredNumber > 12);
            Random r = new Random();
            var randomNum = 0;
            var randomNum2 = 0;
            while (randomNum + randomNum2 != desiredNumber)
            {
                randomNum = r.Next(1, 6);
                randomNum2 = r.Next(1, 6);
                int sum = randomNum + randomNum2;
                Console.WriteLine($"{randomNum} and {randomNum2} = {sum} ");
            }
            Console.ReadKey();
        }
    }
}
