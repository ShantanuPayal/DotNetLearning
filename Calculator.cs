using System;
namespace ConsoleDemo
{
    class Calculator
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        
        public int product(int x, int y) 
        {
        
            return x * y;
        
        }
    }

    class Program
    {
        static void Main(string[] args) 
        {
        Calculator calculator = new Calculator();
        int sum= calculator.add(1, 2);
        int mult= calculator.product(2, 3);

            Console.WriteLine("Addition is " + sum);
            Console.WriteLine("Product is " + mult);

        }
    }
}
