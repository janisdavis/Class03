using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first Word: ");
            string name1 = Console.ReadLine();
            Console.Write("Enter second word: ");
            string name2 = Console.ReadLine();

            int dots = 30 - name1.Length - name2.Length;
            Console.Write(name1);
                for (int i= 0; i< dots; i++)
            {
                Console.Write(".");
            }
            Console.Write(name2);
            Console.ReadKey();
        }
    }
}
