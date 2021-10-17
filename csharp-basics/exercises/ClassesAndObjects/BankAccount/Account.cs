using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account
    {
        string _name;
        double _balance;

        public Account(string name, double balance)
        {
            GetName = name;
            GetBalance = balance;
        }
        public string GetName
        {
            get { return _name; }
            set { _name = value; }
        }
        public double GetBalance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public void ShowUserNameAndBalance()
        {
            if (_balance > 0)
            {
                Console.WriteLine($"{GetName}, ${GetBalance,0:0.00}");
            }
            else
            {
                _balance = Math.Abs(GetBalance);
                Console.WriteLine($"{GetName}, - $ {GetBalance,0:0.00}");
            }
        }
    }
}
