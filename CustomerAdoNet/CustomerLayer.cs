using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAdoNet
{
    public  class CustomerLayer
    {
        private string _connectionString;

        public CustomerLayer(IConfiguration iconfiguration)
        {
            _connectionString = iconfiguration.GetConnectionString("Default");
        }

        public void customers()

        {
            using (SqlConnection con=new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from Customer", con);
                con.Open();
                Console.WriteLine("Connection established");

                SqlDataReader reader= cmd.ExecuteReader();  

                if(reader.HasRows)
                {
                    while (reader.Read()) 
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader["Id"], reader["Name"], reader["Address"], reader["Mob No"]);  
                    }
                }
            }
        }

        public void customercrud()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    //Create an instance of SqlCommand class, specifying the T-SQL command 
                    //that we want to execute, and the connection object.
                    SqlCommand cmd = new SqlCommand("insert into Customer values ( 'payll', 'barshi', 25698765)", connection);
                    connection.Open();
                    //Since we are performing an insert operation, use ExecuteNonQuery() 
                    //method of the command object. ExecuteNonQuery() method returns an 
                    //integer, which specifies the number of rows inserted
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("Inserted Rows = " + rowsAffected);

                    //Set to CommandText to the update query. We are reusing the command object, 
                    //instead of creating a new command object
                    cmd.CommandText = "update Customer set [Mob No]= 100001 where Id =2";
                    //use ExecuteNonQuery() method to execute the update statement on the database
                    rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("Updated Rows = " + rowsAffected);

                    //Set to CommandText to the delete query. We are reusing the command object, 
                    //instead of creating a new command object
                    cmd.CommandText = "delete from Customer where Id =3";
                    //use ExecuteNonQuery() method to delete the row from the database
                    //
                    rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("Deleted Rows = " + rowsAffected);

                }
                catch (Exception ex)
                {
                    // Handle Exceptions, if any
                    Console.WriteLine(ex.Message);
                }
            }

        }


    }
}
