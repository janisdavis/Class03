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
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char i in vowels)
            {
                Console.WriteLine(vowels);
            }

            for (int i = 0; i < vowels.Length; i++)
            {
                Console.WriteLine(vowels[i]);
            }
            Console.ReadKey();
        }
    }
}
