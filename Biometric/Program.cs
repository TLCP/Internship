using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; 

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = @"server=localhost;userid=Mike;password=1234;database=login_db";

            MySqlConnection conn = null; //Connection
            MySqlDataReader rdr = null; //Reads Data

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                Console.WriteLine("MySQL version : {0}", conn.ServerVersion);

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
//                cmd.CommandText = "CREATE DATABASE login_db;";
//                cmd.CommandText = "CREATE TABLE id (username VARCHAR(30), password VARCHAR(30));";
//                cmd.CommandText = "INSERT INTO id(username, password) VALUES(@username, @password)";
//                cmd.Prepare();
//                cmd.Parameters.AddWithValue("@username","Mike");
//                cmd.Parameters.AddWithValue("@password", "ekim");
//                cmd.ExecuteNonQuery();
//                cmd.CommandText = "INSERT INTO id(username, password) VALUES(@username2, @password2)";
//                cmd.Prepare();
//                cmd.Parameters.AddWithValue("@username2","Nick");
//                cmd.Parameters.AddWithValue("@password2", "kcin");
//                cmd.ExecuteNonQuery();
//                cmd.CommandText = "INSERT INTO id(username, password) VALUES(@username3, @password3)";
//                cmd.Prepare();
//                cmd.Parameters.AddWithValue("@username3", "Noelle");
//                cmd.Parameters.AddWithValue("@password3", "elleon");
//                cmd.ExecuteNonQuery();

//                cmd.CommandText = "SELECT * FROM id;";
//                rdr = cmd.ExecuteReader();
//                while (rdr.Read())
//                {
//                    Console.WriteLine("Username: " + rdr.GetString(0) + "\nPassword: " + rdr.GetString(1));
//                }
                while(true)
                {
                    Console.Write("\nEnter\n Username: ");
                    string user = Console.ReadLine();
                    Console.Write(" Password: ");
                    string pass = Console.ReadLine();

                    cmd.CommandText = "SELECT * FROM id WHERE username = '" + user + "';";
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        string TruePass = rdr.GetString(1);
                        if (pass == TruePass)
                        {
                            Console.WriteLine(" Login Successful");
                        }
                        else 
                        {
                            Console.WriteLine(" That combination doesn't exist");
                        }
                    }
                    rdr.Close(); // <- too easy to forget
                    rdr.Dispose(); // <- too easy to forget
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }   
        }
    }
}
