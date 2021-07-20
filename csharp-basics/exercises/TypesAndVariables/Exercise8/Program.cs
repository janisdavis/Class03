using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your minutes:");
            
            double day, year, inputMin;

            inputMin = Convert.ToInt32(Console.ReadLine());
            year = inputMin / (24 * 60 * 365);
            day = inputMin / (24 * 60);
            Console.WriteLine($"Your converted times is {Math.Round(day,2)} days."); 
            Console.WriteLine($"Your converted times is {year} years.");
            Console.ReadKey();



        }
        }
}
