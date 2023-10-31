namespace System
{

    delegate int MyDel();
    public class MyMath
    {
        public int a;
        public int b;

        public MyMath(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int add()
        {
            return a + b;
        }
        public int product()
        {
            return a*b;
        }

    }

        class Program
    {
            
        static void Main()
        {
            MyMath m1 = new MyMath(5, 10);
            MyDel del = new MyDel(m1.add);

            Console.WriteLine("Addition is " + del());

            MyDel del1 = new MyDel(m1.product);
            Console.WriteLine("product is " + del1());


        }
                


    }
}