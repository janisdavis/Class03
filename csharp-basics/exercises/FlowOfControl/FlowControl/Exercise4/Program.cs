using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number of day: ");

            var dayNumber = Console.ReadLine();
            
            if(dayNumber == "7")
            {
                Console.WriteLine("Sunday");
            }    
            else if(dayNumber == "6")
            {
                Console.WriteLine("Saturday");
            }
            else if (dayNumber == "5")
            {
                Console.WriteLine("Friday");
            }
            else if (dayNumber == "4")
            {
                Console.WriteLine("Thursday");
            }
            else if (dayNumber == "3")
            {
                Console.WriteLine("Wednesday");
            }
            else if (dayNumber == "2")
            {
                Console.WriteLine("Tueseday");
            }
            else if (dayNumber == "1")
            {
                Console.WriteLine("Monday");
            }
            else
            {
                Console.WriteLine("This is not a day");
            }


            Console.ReadKey();

        }
    }
}
