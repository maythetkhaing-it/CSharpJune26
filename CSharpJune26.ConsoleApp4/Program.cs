using CSharpJune26.ConsoleApp4;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");

DapperService dp = new DapperService();
dp.Delete();
dp.Create();
dp.Update();
dp.Read();

Console.ReadLine();

public class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public string FatherName { get; set; }

    public string StudentNo { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime DateOfBirth { get; set; }

    public bool IsDelete { get; set; }

    }
