namespace System
{
    public class Account
    {
        int id;
        static int getid;


        public string Name { get; set; }
        public double Balance { get { return Balance; } protected set { Balance = value; } }

        public Account(string name, double balance)
        {
            id = ++getid;
            Name = name;
            Balance = balance;

        }


        public virtual void withdraw(int k) { }

        public virtual void deposit(int k) { }

        public string ToString(Account s)

        {
            return "Id no: " + id + "\t" + "Name: " + Name + "\t" + "Balance:  " + Balance;
        }


        
    }
    public class SavingsAccount :Account
    {
        public SavingsAccount(string name, double balance):base(name, balance) { }

        public override void withdraw(int k)
        {
            if (Balance > 0)
            {
                Balance -= k;
                Console.WriteLine("Remaining Balance is" + Balance);
            }
            else
                throw new Exception("Not Enough funds");
        }
        public override void deposit(int k) 
        {
            Balance+= k;
            Console.WriteLine("Your Acc Deposited with {0} and new balance is {1}", k, Balance);
        }
    }

    public class CurrentsAccount : Account
    {
        public CurrentsAccount(string name, double balance): base(name, balance) { }
        public override void withdraw(int k)
        {
            if (Balance > 0)
            {
                Balance -= k;
                Console.WriteLine("Remaining Balance is" + Balance);
            }
            else
                throw new Exception("Not Enough funds");
        }
        public override void deposit(int k)
        {
            Balance += k;
            Console.WriteLine("Your Acc Deposited with {0} and new balance is {1}", k, Balance);
        }
    }


    

        class Program
        {
            
            static void Main()
            {
            Account a1 = new SavingsAccount("John", 4500);
            Account a2 = new CurrentsAccount("Rob", 1800);
            Console.WriteLine(a1.ToString(a1));
            Console.WriteLine("After adding 2000");
            a1.deposit(2000);
            Console.WriteLine("After withdrawing 1000");
            a1.withdraw(1000);
            Console.WriteLine(a1.ToString(a1));
            Console.WriteLine();
           
         
            Console.WriteLine(a2.ToString(a2));
            Console.WriteLine("After adding 2000");
            a2.deposit(2000);
            Console.WriteLine("After withdrawing 1000");
            a2.withdraw(1000);
            Console.WriteLine(a2.ToString(a2));


        }
                


        }
}