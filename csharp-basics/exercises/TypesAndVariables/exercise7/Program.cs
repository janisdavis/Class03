using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Please input your letters:");
            string sentence = Console.ReadLine();

            char[] charArr = sentence.ToCharArray();
            foreach (char ch in charArr)
            {
                if (char.IsUpper(ch))
                {
                    sum++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Your letters in the string are: {sum}");
            Console.ReadKey();
        }
    }
}
