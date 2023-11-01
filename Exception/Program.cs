//create the userdefine Exception and handel it

namespace ExceptionProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgeCheker ageCheker = new AgeCheker();
            try
            {
                ageCheker.CheckAge(10);
                ageCheker.CheckAge(-7);
            }
            catch ( MyException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                ageCheker.CheckAge(190);
            }
            catch( Exception e )
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
