using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJune26.ConsoleApp4
{
    internal class DapperService
    {
        private readonly SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder()
        {
            DataSource = "DESKTOP-MN2FBFP\\MSSQLSERVER2022",
            InitialCatalog = "CSharpJune26",
            UserID = "sa",
            Password = "love",
            TrustServerCertificate = true
        };
    public void Read()
        {
           using (IDbConnection connection = new SqlConnection(sb.ConnectionString)) //when use "using", do not need to call db.Close()
            {
                connection.Open();
                List<Student> lst = connection.Query<Student>("SELECT * FROM [dbo].[Students];").ToList();
                foreach (var item in lst)
                {
                    Console.WriteLine($"Id :{item.StudentId}, Name: {item.StudentName}");
                }
                
            }
            //errors occur only when the code executes.
            //dynamic a = new { StudentID = 1, StudentName = "Mg Ba" }; //dynamic testing
            //a.Id = 2;  //dynamic testing
            //a.fasfasd = 3;  //dynamic testing
        }

    public void Create()
        {
            using (IDbConnection connection = new SqlConnection(sb.ConnectionString))
            {
                connection.Open ();
                List<Student> lst = (List<Student>)connection.Query<Student>(@"INSERT INTO Students
                                            (StudentName, FatherName, StudentNo, Email, Phone, DateOfBirth)
                                            VALUES
                                            ('Ma Ma', 'U Ba Tun', 'STU006', 'mama@gmail.com', '0912309876', '2003-05-10'),
                                            ('Nu Nu', 'U Nu Nu', 'STU007', 'nunu@gmail.com', '0923412345', '2001-11-25')
                                            ;");

            }
        }
        public void Update()
        {
            using (IDbConnection connection = new SqlConnection(sb.ConnectionString))
            {
                connection.Open();
                List<Student> lst = (List<Student>)connection.Query<Student>(@"UPDATE Students SET IsDelete = 1 WHERE StudentID = 1;");

            }
        }

        public void Delete()
        {
            using (IDbConnection connection = new SqlConnection(sb.ConnectionString))
            {
                connection.Open();
                int result = connection.Execute("Delete from Students where studentNo in ('STU006','STU007')");
                Console.WriteLine($"Rows affected:  {result}");
            }
        }

    }
}