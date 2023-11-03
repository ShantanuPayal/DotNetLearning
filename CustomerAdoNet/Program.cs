// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;

namespace CustomerAdoNet
{
    internal class Program
    {
        private static IConfiguration _iconfiguration;
        static void Main(string[] args)

        {

            GetAppSettingsFile();
            PrintCustomer();
        }

        static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("Appsettings.json", optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
        }

        static void PrintCustomer() 
        {
            CustomerLayer cust = new CustomerLayer(_iconfiguration);
            cust.customers();
            cust.customercrud();
            cust.customers();
        }
    }
}