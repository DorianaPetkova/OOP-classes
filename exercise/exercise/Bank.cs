using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace exercise
{
    internal class Bank
    {
        private int account;
        private double balance;
        public int Account { get { return account; } set { account = value; } }
        public double Balance { get { return account; } set { account = (int)value; } }
        public Bank() 
        { account = 0; 
            balance = 0; 
        }
        public Bank(int account,  double balance) : this()
        {
            Account = account;
            Balance = balance;
        }
        public void Deposit(double deposit)
        {
            Balance = (Balance+deposit);
        }
        public void Withdraw(double withdraw)
        {
            
            Balance = (Balance-withdraw);
        }
        public void Display()
        {
            Console.WriteLine($"Current: {Balance}");
        }
    }
}
