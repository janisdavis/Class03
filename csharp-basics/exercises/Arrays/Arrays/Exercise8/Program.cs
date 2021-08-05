using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mime;
using System.Collections;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
            game();
            string choice;
            do
            {
                choice = getMenu();
                if (choice == "again")
                {
                    Console.WriteLine("\nlet's play again..Riddle me this..\n"); 
                    game();
                    Console.ReadKey();
                }
                else if (choice == "quit")
                {
                    Console.WriteLine("\nThank you for playing!");
                    Console.ReadKey();
                }
            } while (choice != "quit");
        }
        private static void game()
        {
            int lives = 5;
            string guessWho = randomWord();
            Console.Write("Word:  ");
            char[] charList = guessWho.ToCharArray(); 
            char[] guessList = new char[guessWho.Length]; 
            ArrayList wrongList = new ArrayList(); 
            int wordLength = charList.Length;
            for (int i = 0; i < guessList.Length; i++)
            {
                guessList[i] = '_';
                Console.Write($"{guessList[i]} ");
            }
            Console.Write("\n\nMisses:  ");
            Console.Write("\nGuess:  ");
            while (wordLength != 0 & lives != 0)
            {
                char myGuess = Convert.ToChar(Console.ReadLine());
                if (Array.IndexOf(charList, myGuess) >= 0)
                {
                    for (var i = 0; i < charList.Length; i++)
                    {
                        if (charList[i] == myGuess)
                        {
                            guessList[i] = myGuess;
                            wordLength--;
                        }
                    }
                }
                else
                {
                    wrongList.Insert(wrongList.Count, myGuess);
                    lives--;
                }
                Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
                Console.Write("Word:  ");
                for (int i = 0; i < guessList.Length; i++)
                {
                    Console.Write($"{guessList[i]} ");
                }
                Console.Write("\n\nMisses:  ");
                foreach (var item in wrongList)
                {
                    Console.Write(item.ToString());
                }
                if (lives == 0 | wordLength == 0)
                    if (lives == 0)
                        Console.WriteLine("\n\nNo more lives left!\n");
                    else
                        Console.WriteLine("\n\nHey! You guessed it!\n");
                else
                    Console.Write("\nGuess:  ");
            }
        }
        private static string randomWord()
        {
            string[] myWords;
            myWords = new string[10] { "pikachu", "terminator", "deadpool", "juice", "everest", "transformer", "basketball", "aquaman", "ironman", "mountain" };
            var rand = new Random();
            int i = rand.Next(0, 10);
            return myWords[i];
        }
        public static string getMenu()
        {
            Console.WriteLine("Play \"again\" or \"quit\"?");
            Console.Write("Enter your choice : ");
            var keyboard = Convert.ToString(Console.ReadLine());
            while (keyboard != "quit" & keyboard != "again")
            {
                Console.WriteLine("\nError, please enter \"again\" or \"quit\"");
                keyboard = Convert.ToString(Console.ReadLine());
            }
            return keyboard;
        }
    }
}