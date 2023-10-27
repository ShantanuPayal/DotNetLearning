using System;

namespace Bank
{
    class Account
    {
        private static int nextId = 1;
        public int Id { get; }
        public string Name { get; set; }
        private double _balance;
        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Balance cannot be negative.");
                }
                else
                {
                    _balance = value;
                }
            }
        }

        private static float InterestRate = 0.07f;
        private const float MinBalance = 1000f;

        public Account(string name, double balance)
        {
            Id = nextId++;
            Name = name;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than 0.");
            }
            else
            {
                Balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdraw amount must be greater than 0.");
            }
            else if (Balance - amount < MinBalance)
            {
                Console.WriteLine("Insufficient balance. Minimum balance should be maintained.");
            }
            else
            {
                Balance -= amount;
            }
        }

        public static double CalculateInterest(Account account)
        {
            double interest = account.Balance * InterestRate;
            account.Balance += interest;
            return interest;
        }

        public void Display()
        {
            Console.WriteLine("Name of Bank: Your Bank");
            Console.WriteLine("Copyright © 2023 Your Bank, Inc.");
            Console.WriteLine($"Account ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Balance: {Balance:C}");
            Console.WriteLine($"Interest Received: {CalculateInterest(this):C}");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("John Doe", 2000);
            a1.Deposit(500);
            a1.Withdraw(700);
            a1.Display();

            Account a2 = new Account("Jane Smith", 1500);
            a2.Deposit(1000);
            a2.Withdraw(2000);
            a2.Display();
        }
    }
}
