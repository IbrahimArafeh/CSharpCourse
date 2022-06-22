using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Session4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ServerName;
            string databaseName;
            string username;
            string password;

            Console.WriteLine("Enter you ServerName : ");
            ServerName = Console.ReadLine();

            Console.WriteLine("Enter you DatabaseName : ");
            databaseName = Console.ReadLine();

            Console.WriteLine("Enter you Username : ");
            username = Console.ReadLine();

            Console.WriteLine("Enter you password : ");
            password = Console.ReadLine();

            SqlConnection conn = new SqlConnection("Data Source="+ ServerName +";" + "Initial Catalog="+databaseName + ";" + "User ID="+ username +";" + "Password="+ password +";");

            try
            {
                List<string> listResult = new List<string>();
                Console.WriteLine("The connection is correctry");
                //Console.ReadKey();


                // Select from database
                //using(SqlCommand cmd = new SqlCommand("select * from person", conn))
                //{
                //   using(SqlDataReader reader = cmd.ExecuteReader())
                //    {
                //        while(reader.Read())
                //        {
                //            string firstName = reader["FName"].ToString();
                //            listResult.Add(firstName);
                //            Console.WriteLine("The database value is : " + firstName);
                //            Console.ReadKey();
                //        }
                //    }
                //}

                /// Insert new row into database
                SqlCommand cmd = new SqlCommand("insert into Person(FName,LName,Address,Phone) values (@fname,@lname,@address,@phone)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@fname", "Nour");
                cmd.Parameters.AddWithValue("@lname", "Najm");
                //cmd.Parameters.AddWithValue("@dob", "01-01-2022");
                cmd.Parameters.AddWithValue("@address", "Germany");
                cmd.Parameters.AddWithValue("@phone", "0569433903");

                cmd.ExecuteNonQuery();
                Console.WriteLine("The data has been added");
                conn.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
          
        }
    }
}