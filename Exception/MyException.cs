using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProject
{
    
    internal class MyException : ApplicationException
    {
       
        public MyException(string msg):base(msg){
          
        }
    }
}
