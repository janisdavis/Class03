using System;
using System.Linq;


namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            int[] arr = { 25, 78, 87 };

        Console.WriteLine(arr.Max());
            Console.WriteLine("Input the 1st number: ");
            var input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the 2nd number: ");
            var input2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the 3rd number: ");
            var input3 = int.Parse(Console.ReadLine());
            int[] newArray = { input1, input2, input3 };
            Console.ReadKey();
            /*
            todo - expected output:
            Input the 1st number: 25
            Input the 2nd number: 78
            Input the 3rd number: 87
             */
        }
    }
}
