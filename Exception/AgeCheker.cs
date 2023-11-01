using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProject
{
    public class AgeCheker
    {

        public void CheckAge(int age)
        {
            if (age < 0)
            {
                throw new MyException("Negative age not allowed");
            }
            if (age >100)
            {
                throw new MyException("Age is above 100 years");
            }
            Console.WriteLine("Welcome to Age class");
        }
    }
}
