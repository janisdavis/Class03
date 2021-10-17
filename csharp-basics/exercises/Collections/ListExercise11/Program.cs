using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<string>()
            {"John Connor", "Elvis Presley", "Tony Stark", "Hulk", "Captain America", "Batman", "Superman","The Ridler","Poison Ivy","Ant-Man"
            };

            myList.Insert(5, "Black Widow");
            Console.WriteLine(string.Join(",",  myList));
            myList.RemoveAt(10);
            myList.Add("Dr.Who");
            Console.WriteLine(string.Join(",", myList));
            myList.Sort();
            Console.WriteLine(string.Join(",", myList));
            Console.WriteLine(myList.Contains("Foobar"));
            foreach (object o in myList)
            {
                Console.WriteLine(o);
            }
            Console.ReadKey();
            //TODO: Create an List with string elements

            //TODO: Add 10 values to list

            //TODO: Add new value at 5th position

            //TODO: Change value at last position (Calculate last position programmatically)

            //TODO: Sort your list in alphabetical order

            //TODO: Check if your list contains "Foobar" element

            //TODO: Print each element of list using loop




        }
    }
}
