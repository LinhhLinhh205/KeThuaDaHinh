using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT01
{
    class Account
    {
        private double _balance;
        protected double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public Account()
        {

        }

        public Account(double balance)
        {
            this._balance = balance;
        }
        public virtual bool Withdraw(double amount)
        {
            return false;
        }
        public virtual bool Deposit(double amount)
        {
            return false;
        }
        public virtual void PrintBalance()
        {
            Console.WriteLine($"So du:{_balance}");
        }
    }
    class SavingAccount : Account
    {
        private double _interesRate=0.8;
        public SavingAccount(double balance) : base(balance)
        {

        }
        public override bool Withdraw(double amount)
        {
            if (0 < amount && amount < Balance)
            {
                Balance = Balance - (amount + amount * _interesRate);
                Console.WriteLine("Giao dich thanh cong");
                Console.WriteLine($"So tien da nop la:{amount}");

            }
            

            else Console.WriteLine("Giao dich that bai");
            return false;
        }
        public override bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance = Balance + (amount + amount * _interesRate);
                Console.WriteLine("Them tien thanh cong");
                Console.WriteLine($"So tien da them:{amount}");
            }
            else Console.WriteLine("Them tien that bai");
            return false;
        }
        public override void PrintBalance()
        {
            Console.WriteLine($"So du:{Balance}");
        }

    }
    class CheckingAccount : Account
    {
        public CheckingAccount(double balance):base(balance)
        {

        }
        public override bool Withdraw(double amount)
        {
            if (amount>0 && amount < Balance)
            {
                Balance = Balance - amount;
                Console.WriteLine("Giao dich thanh cong");
                Console.WriteLine($"So tien da nop la:{amount}");
                
            }


            else Console.WriteLine("Giao dich that bai");
            return false;

        }
        public override bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance = Balance + amount;
                Console.WriteLine("Them tien thanh cong");
                Console.WriteLine($"So tien da them:{amount}");
            }
            else Console.WriteLine("Them tien that bai");
            return false;
        }
        public override void PrintBalance()
        {
            Console.WriteLine($"So du:{Balance}");
        }
        class Program
        {

            static void Main(string[] args)
            {
                
                Account ac1 = new CheckingAccount(1000);
                ac1.Withdraw(200);
                ac1.Deposit(500);
                ac1.PrintBalance();
                
                Console.ReadLine();
            }
        }
    }
}
