using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        //TODO: print all vowels using for and foreach
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your name: ");
            int age = Convert.ToInt32( Console.ReadLine());
            if (age > 45)
            {
                Console.WriteLine($"Hi, {name} You are old as fuck");
            }
            else
            {
                Console.WriteLine($"Hi, {name} You are {age} old");
            }
            Console.ReadKey();
        }
    }
}
