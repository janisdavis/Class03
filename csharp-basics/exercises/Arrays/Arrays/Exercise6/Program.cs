using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray;
            myArray = new int[] { 25, 14, 56, 15, 36, 56, 77, 18, 29, 49 };
            
            int[] myArrayCopy = new int[10];
            Array.Copy(myArray, myArrayCopy, 10);
            myArray[9] = -7;
            Console.WriteLine(string.Join(",", myArray));
            Console.WriteLine(string.Join(",", myArrayCopy));

            Console.ReadKey();
        }
    }
}
