using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfBaroda
{
    internal class Savings : Account
    {
        public Savings(string Name, int Balance) : base(Name, Balance)
        {
        }

        public override void Deposit(int amt)
        {

                Balance += amt;
                Console.WriteLine($"Deposited {amt:C} from Savings Account {Id}. New Balance: {Balance:C}");
           
        }

        public override void Withdraw(int amt)
        {
            if (amt > 0 && amt <= Balance)
            {
                Balance -= amt;
                Console.WriteLine($"Withdrawn {amt:C} from Savings Account {Id}. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
            
               
        }
    }
}
