//USING CLASS LIBRARY..............
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialLibrary
{
    public class Factorial
    {
        public int fact(int x) 
        {
            if(x == 0) 
                return 1;
            int res = 1;
            for(int i=1;i<=x; i++)
            {
                res *= i;
            }
            return res;
        }
    }
}

using System;
using System.Security.Authentication;
using FactorialLibrary;
class Program
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        
        Factorial cal = new Factorial();
        int res = cal.fact(num);
        Console.WriteLine(res);
      

    }
}
