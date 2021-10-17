﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string> { "Red", "Green", "Violet", "White", "Black" };
            
            Console.WriteLine(string.Join(",", colors));

            //TODO: Remove the third element from the list.

            Console.WriteLine("After removing third element from the list:");
            colors.Remove(colors[2]);
            Console.WriteLine(string.Join(",", colors));
            Console.ReadKey();
        }
    }
}
