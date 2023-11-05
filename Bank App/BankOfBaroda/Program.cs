// See https://aka.ms/new-console-template for more information
namespace BankOfBaroda
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Create accounts
            Savings savingsAccount = new Savings("Shantanu", 70000);
            savingsAccount.Deposit(1000);
            savingsAccount.Withdraw(500);
            
            Current currentAccount = new Current("Payal", 4000);
            currentAccount.Deposit(2000);
            currentAccount.Withdraw(1000);

            NotificationHandler notificationHandler = new NotificationHandler();
            savingsAccount.MoneyWithdrawn += notificationHandler.SendNotification;
            currentAccount.MoneyWithdrawn += notificationHandler.SendNotification;




        }
    }
}
