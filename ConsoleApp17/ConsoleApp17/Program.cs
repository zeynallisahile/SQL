using System;
using System.Data.SqlClient;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. Stadion əlavə et");
            Console.WriteLine(" 2. Stadionları göstər");
            Console.WriteLine(" 3. İstifadəçi əlavə et");
            Console.WriteLine("4. İstifadəçiləri göstər");
            Console.WriteLine("5. Rezervasiyaları göstər");
            Console.WriteLine("6. Rezervasiya yarat");
            Console.WriteLine("7. Verilmiş Id-li stadionun rezervasiyalarını göstər");
            Console.WriteLine("8. Verilmiş Id-li userin rezervasiyalarını göstər");
            Console.WriteLine(" 9. Verilmiş Id-li rezervasiyanı sil");

            Console.WriteLine("menyudan bir reqem daxil edin :");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    string connection = @"Server=C:\Users\acer\Desktop\Sahilə;Database=Football;Trusted_Connection=TRUE";
                    SqlConnection con = new SqlConnection(connection);
                    Console.WriteLine("Stadionun adini daxil edin:");
                    string name = Console.ReadLine();
                    Console.WriteLine("HourPrice adini daxil edin:");
                    int hourPrice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Capacity adini daxil edin:");
                    int capacity = Convert.ToInt32(Console.ReadLine());
                    con.Open();
                    string query = $"INSERT INTO Stadions( Name,HourPrice,Capacity) VALUES('{name}',{hourPrice},{capacity})";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int result = cmd.ExecuteNonQuery();
                    Console.WriteLine(result + "eleve edildi");
                    con.Close();
                    break;

                case 2:
                    string connection1 = @"Server=C:\Users\acer\Desktop\Sahilə;Database=futboll2;Trusted_Connection=TRUE";
                    SqlConnection con1 = new SqlConnection(connection1);
                    con1.Open();
                    query = "SELECT*FROM Stadions";
                    cmd = new SqlCommand(query, con1);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Console.WriteLine("stadions");
                    while (reader.Read())
                    {
                        Console.WriteLine($"name:{reader.GetString(1)}\nHourPrice:{reader.GetInt32(2)}\ncapacity:{reader.GetInt32(3)}");

                    }
                    con1.Close();
                    break;                  

                case 3:
                    string connection2 = @"Server=C:\Users\acer\Desktop\Sahilə;Database=futboll2;Trusted_Connection=TRUE";
                    SqlConnection con2 = new SqlConnection(connection2);
                    Console.WriteLine(" fullname daxil edin ");
                    string fullname = Console.ReadLine();
                    Console.WriteLine(" Email daxil edin ");
                    string email = Console.ReadLine();
                    con2.Open();
                    string query1 = $"INSERT INTO Users(FullName,Email)VALUES('{fullname}','{email}')";
                    SqlCommand cmd1 = new SqlCommand(query1, con2);
                    int result1 = cmd1.ExecuteNonQuery();
                    Console.WriteLine(result1 + "eleve edildi");
                    con2.Close();
                    break;
                case 4:
                    string connection3 = @"Server=C:\Users\acer\Desktop\Sahilə;Database=futboll2;Trusted_Connection=TRUE";
                    SqlConnection con3 = new SqlConnection(connection3);
                    con3.Open();
                    query = "SELECT*FROM Users";
                    cmd = new SqlCommand(query, con3);
                    SqlDataReader reader4 = cmd.ExecuteReader();
                    Console.WriteLine("users");
                    while (reader4.Read())
                    {
                        Console.WriteLine($"fullname:{reader4.GetString(1)}\nemail:{reader4.GetString(2)}");

                    }
                    con3.Close();
                    break;
                    
            }
        }
    }
}

