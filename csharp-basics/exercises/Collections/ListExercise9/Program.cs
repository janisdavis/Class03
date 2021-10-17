using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            var secondList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink",
                "Pink Drug Lord"
            };

            Console.WriteLine(string.Join(",", firstList));
            Console.WriteLine(string.Join(",", secondList));
            //TODO: Write a C# program to join two lists.
            //...
            firstList.AddRange(secondList);
            Console.WriteLine(string.Join(",", firstList));
            Console.ReadKey();
        }
    }
}
