using System;
namespace DAC
{
    public class Student
    {
        public void add()
        {
            Console.WriteLine("Adding stud in Dac ");
        }


    }

}
namespace DBDA
{
    public class Student
    {
        public void add()
        {
            Console.WriteLine("Adding stud in DBDA ");
        }


    }
}
class Program

{
    static void Main(string[] args)
    {
        DAC.Student dacstudent = new DAC.Student();
        dacstudent.add();

        DBDA.Student dbdastudent = new DBDA.Student();
        dbdastudent.add();
        
    }
}