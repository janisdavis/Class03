using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = RandomIntegers(20);
            Console.Write("There are few integers given: ");
            Console.WriteLine("[{0}]", string.Join(", ", integers));
            Console.WriteLine("Which number index would you like to find?");

            int searchFor = Convert.ToInt16(Console.ReadLine());
            bool foundIt = false;
            int i;

            for (i = 0; i < integers.Length; i++)
            {

                if (searchFor == integers[i])
                {
                    foundIt = true;
                    break;
                }
            }

            if (foundIt)
            {
                Console.WriteLine("Found " + searchFor + " at index " + i);
            }
            else
            {
                Console.WriteLine(searchFor + " is not in the array");
            }



        }
        static int[] RandomIntegers(int n)
        {
            var list = new List<int>(n);
            var random = new Random();


            for (int i = 0; i < n; i++)
            {
                var randomNumber = random.Next(0, 99);
                list.Add(randomNumber);
            }

            return list.ToArray();
            
        }
    }
}
