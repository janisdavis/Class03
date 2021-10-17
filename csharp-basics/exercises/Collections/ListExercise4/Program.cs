using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Create a list and add some colors to the list
            var colors = new List<string>();
            {
                colors.Add("Red");
                colors.Add("Green");
                colors.Add("Orange");
                colors.Add("White");
                colors.Add("Black");

                string element1 = colors[0];
                string element3 = colors[3];
                Console.WriteLine("First element: " + element1);
                Console.WriteLine("Third element: " + element3);
                
                Console.ReadKey();

            }

            //fixme
            //string element = ...;
            //Console.WriteLine("First element: " + element);

            //fixme
            //element = ...;
            //Console.WriteLine("Third element: " + element);
        }
    }
}
