using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account benben = new Account("Benson", 17.50);
            Account ludacris = new Account("50Cent", -100);
            benben.ShowUserNameAndBalance();
            ludacris.ShowUserNameAndBalance();
            Console.ReadKey();
        }
    }
}
