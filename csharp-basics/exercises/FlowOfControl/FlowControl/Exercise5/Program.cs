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
            Console.WriteLine("Enter letters and keypad no. will be shown: ");
            string userInput = Console.ReadLine();
            char[] symbols = userInput.ToLower().ToCharArray();

            PhoneKeyPad(symbols);
            Console.ReadKey();
        }
        
        static void PhoneKeyPad(char[] symbols)
        {

            for (int i = 0; i < symbols.Length; i++)
            {

                switch (symbols[i])
                {

                    case 'a':
                    case 'b':
                    case 'c':
                        Console.WriteLine("2");
                        break;
                    case 'd':
                    case 'e':
                    case 'f':
                        Console.WriteLine("3");
                        break;
                    case 'g':
                    case 'h':
                    case 'i':
                        Console.WriteLine("4");
                        break;
                    case 'j':
                    case 'k':
                    case 'l':
                        Console.WriteLine("5");
                        break;
                    case 'm':
                    case 'n':
                    case 'o':
                        Console.WriteLine("6");
                        break;
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                        Console.WriteLine("7");
                        break;
                    case 't':
                    case 'u':
                    case 'v':
                        Console.WriteLine("8");
                        break;
                    case 'w':
                    case 'x':
                    case 'z':
                    case 'y':
                        break;
                        Console.WriteLine("9");
                    case ' ':
                        Console.WriteLine("Space");
                        break;

                }
                Console.WriteLine();
            }
        }
    }
}
