using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeADONet
{
    public  class EmployeeLayer
    {
        private string _connectionString;
        
        public EmployeeLayer(IConfiguration iconfiguration)
        {
            _connectionString = iconfiguration.GetConnectionString("Default");
        }

        public void Employees()
        {
            using (SqlConnection con=new SqlConnection( _connectionString )) 
            {
                SqlCommand cmd = new SqlCommand("select * from Employee", con);
                con.Open();
                Console.WriteLine("Now Actually Connected");

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while(reader.Read()) 
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t", reader["Id"], reader["Name"], reader["Salary"]); 
                    }
                }


            
            }
        }

        public void Employee_insert()
        {
            using(SqlConnection connection = new SqlConnection( _connectionString ))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into Employee values ('Sanket Streeling', 68500)", connection);
                    connection.Open();
                    //int rowsAffected=
                    //cmd.ExecuteNonQuery();
                    // Console.WriteLine("Updated Rows =" + rowsAffected);

                
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void EmployeeUpdate()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open(); // Open the database connection

                    string sql = "UPDATE Employee SET Salary = 90000 WHERE Id = 4";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine("Updated Rows = " + rowsAffected);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}


