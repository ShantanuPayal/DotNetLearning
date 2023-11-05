using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfBaroda
{
    class NotificationHandler
    {
        public void SendNotification(int amt, int Balance)
        {
            Console.WriteLine($"SMS Notification: Amount withdrawn: {amt:C}, New Balance: {Balance:C}");
            Console.WriteLine($"Email Notification: Amount withdrawn: {amt:C}, New Balance: {Balance:C}");
        }
    }
}
