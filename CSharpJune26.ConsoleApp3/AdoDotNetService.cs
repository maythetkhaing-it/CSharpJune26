using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJune26.ConsoleApp3
{
    internal class AdoDotNetService
    {
        public void Read()
        {
            SqlConnectionStringBuilder sc = new SqlConnectionStringBuilder();

            sc.DataSource = "DESKTOP-MN2FBFP\\MSSQLSERVER2022"; //"localhost"; //Server name
            sc.InitialCatalog = "AdventureWorks2019"; //Database name
            sc.UserID = "sa"; //Username
            sc.Password = "love"; //Password
            sc.TrustServerCertificate = true; //Trust the server certificate

            SqlConnection connection = new SqlConnection(sc.ConnectionString);

            connection.Open();
            Console.WriteLine("Connection opened successfully!");

            string sql = @"SELECT [user_id]
                                  ,[username]
                                  ,[phone]
                                  ,[age]
                                  ,[address]
                                  ,[user_balance]
                              FROM [dbo].[Users]";

            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            connection.Close();
            Console.WriteLine("Connection closed.");

            foreach (DataRow item in dt.Rows)
            {

                Console.WriteLine(item["user_id"]);
                Console.WriteLine(item["username"]);
                Console.WriteLine(item["phone"]);
                Console.WriteLine(item["address"]);
                Console.WriteLine("=============");

            }
        }

        public void Create()
        {
            SqlConnectionStringBuilder sc = new SqlConnectionStringBuilder();

            sc.DataSource = "DESKTOP-MN2FBFP\\MSSQLSERVER2022"; //"localhost"; //Server name
            sc.InitialCatalog = "AdventureWorks2019"; //Database name
            sc.UserID = "sa"; //Username
            sc.Password = "love"; //Password
            sc.TrustServerCertificate = true;

            SqlConnection connection = new SqlConnection(sc.ConnectionString);
            connection.Open();
            Console.WriteLine("Connection opened successfully!");

            string query = @"INSERT INTO [dbo].[Users]
                               ([user_id]
                               ,[username]
                               ,[phone]
                               ,[age]
                               ,[address]
                               ,[user_balance])
                                VALUES
            ('11', 'John Smith',  '0912345678', 28, 'New York', 150000.00),
            ('12', 'Emily Brown', '0987654321', 25, 'Los Angeles', 230000.50);
            ";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
            Console.WriteLine("Connection closed.");
        }

        public void Update()
        {
            SqlConnectionStringBuilder sc = new SqlConnectionStringBuilder();

            sc.DataSource = "DESKTOP-MN2FBFP\\MSSQLSERVER2022"; //"localhost"; //Server name
            sc.InitialCatalog = "AdventureWorks2019";
            sc.UserID = "sa";
            sc.Password = "love";
            sc.TrustServerCertificate = true;

            SqlConnection conn = new SqlConnection(sc.ConnectionString);
            conn.Open();
            Console.WriteLine("Connection opened successfully!");

            string query = @"UPDATE [dbo].[Users]
                            SET
                                user_balance = 300000.00,
                                address = 'Chicago'
                            WHERE user_id = '1';
                                ";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            Console.WriteLine("Connection closed!");
        }

        public void Delete()
        {
            SqlConnectionStringBuilder sc = new SqlConnectionStringBuilder();
            sc.DataSource = "DESKTOP-MN2FBFP\\MSSQLSERVER2022"; //"localhost"; //Server name
            sc.InitialCatalog = "AdventureWorks2019";
            sc.UserID = "sa";
            sc.Password = "love";
            sc.TrustServerCertificate = true;

            SqlConnection conn = new SqlConnection(sc.ConnectionString);
            conn.Open();

            string query = @"DELETE FROM [dbo].[Users]
                            WHERE user_id = '12';";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
