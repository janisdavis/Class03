using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            first();
            second();

            Console.ReadKey();
        }

        static void first()
        {
            String[] args;   
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;
            int sum = a + b + c + d + e;
            Console.WriteLine(sum);
        }

        static void second()
        {
            String[] args;
            float a = 1;
            float b = 2;
            float c = 3;
            float d = 4.2f;
            float e = 5.3f;
            float sum = a + b + c + d + e;
            Console.WriteLine(sum);
                }
    }
}
