// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;
namespace EmployeeADONet

{
    internal class Program
    {
        private static IConfiguration _iconfiguration;
        static void Main(string[] args)
        {

            GetAppSettingsFile();
            PrintEmployee();
        }

        static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("Appsettings.json", optional: false, reloadOnChange: true);
                  _iconfiguration = builder.Build();
           

        }

        static void PrintEmployee()
        {
            EmployeeLayer emp = new EmployeeLayer(_iconfiguration);
           // emp.Employees();
            emp.Employee_insert();
            emp.Employees();
            emp.EmployeeUpdate();
            emp.Employees();
           
        }
    }
}