using System;
using System.Data.SqlClient;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void AddPost(string title, string content)
        {
            string Connection = @"Server=C:\Users\acer\Desktop\Sahilə;Blog;Trusted_Connection=True";
            Console.WriteLine("Title");
            string title = Console.ReadLine();
            Console.WriteLine("Content");
            string content = Console.ReadLine();
            using (SqlConnection con = new SqlConnection(Connection))
            {
                con.Open();
                string query = $"INSERT INTO Blog(Title, Content) VALUES('{title}','{content}')";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
            }

           }
        }
    }

