using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise8
{
    class SavingsAccount
    {
        double _balance;
        double _totalDeposit;
        double _totalWithdrawal;
        double _totalEarned;
        
        public SavingsAccount(int balance) 
        {
            _balance = balance;
        }
        public double AccauntWithdrawal(int number) 
        {
            _totalWithdrawal += number;
            return _balance - number;

        }
        public double AmountOfDeposit(int number)
        {
            _totalDeposit += number;
            return _balance + number;
        }
        public double MonthlyInterest(double _interest) 
        {
            double interest = _interest / 12;
            double interestSum = _balance * interest;
            _totalEarned += interestSum;
            return _balance + interestSum;
        }
        public void TotalDeposit()
        {
            Console.WriteLine($"Total deposited: ${_totalDeposit}");

        }
        public void TotalWithdrawal()
        {
            Console.WriteLine($"Total withdrawn: ${_totalWithdrawal}");
        }
        public void TotalEarned()
        {
            Console.WriteLine($"Interest earned: $ {_totalEarned}");
        }
        public void EndingBalance() 
        {
            Console.WriteLine($"Ending balance: ${_balance}");
        }
    }
    
}
