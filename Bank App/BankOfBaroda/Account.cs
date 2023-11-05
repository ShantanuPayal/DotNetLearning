using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfBaroda
{
 

    public delegate void MoneyWithdrawnEventHandler(int amt, int Balance);

    abstract class Account
    {
        static Account()
        {
            Console.WriteLine("WELCOME TO BANK OF BARODA");
        }
        private static int idCounter = 0;
        private string name;
        private int balance;

        public int Id { get; }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length >= 2 && value.Length <= 15)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name length should be between 2 and 15 characters.");
                }
            }
        }

        public int Balance
        {
            get { return balance; }
            protected set { balance = value; }
        }

        public event MoneyWithdrawnEventHandler MoneyWithdrawn;

        public Account(string Name, int Balance)
        {
            Id = idCounter++;
            this.Name = Name;
            this.Balance = Balance;
        }

        public abstract void Withdraw(int amt);
        public abstract void Deposit(int amt);
    }

}
