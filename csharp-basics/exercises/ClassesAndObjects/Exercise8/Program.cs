using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much money is in the account? ");
            var savings = new SavingsAccount(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter the annual interest rate: ");
            var interest = Convert.ToInt32(Console.ReadLine());
            Console.Write("How long has the account been opened? ");
            var accOpen = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i <= accOpen; i++)
            {
                Console.Write($"Enter amount deposited for month: {i}: ");
                savings.AmountOfDeposit(Convert.ToInt32(Console.ReadLine()));
                Console.Write($"Enter amount withdrawn for: {i}: ");
                savings.AccauntWithdrawal(Convert.ToInt32(Console.ReadLine()));
                savings.MonthlyInterest(interest);
            }
            savings.TotalDeposit();
            savings.TotalWithdrawal();
            savings.TotalEarned();
            savings.EndingBalance();
            Console.ReadKey();
        }
    }
}
