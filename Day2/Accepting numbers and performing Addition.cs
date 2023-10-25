namespace System
{
    class Add
    {
        public static float add(int  x , int y)
        {
            return x + y;
        }


    }
    class Program
    {
        static void Main(string[] args) 
        {
            Add add = new Add();
            Console.WriteLine("Enter a number");
            string num1=Console.ReadLine();

            Console.WriteLine("Enter a number");
            string num2 = Console.ReadLine();

            int.TryParse(num1, out int x);
            int.TryParse(num2, out int y);
            Console.WriteLine("Addition  of {0} and {1} is  {2}", num1 , num2 , Add.add(x,y));


        }

    }
}