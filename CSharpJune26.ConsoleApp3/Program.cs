
// See https://aka.ms/new-console-template for more information
using CSharpJune26.ConsoleApp3;
using Microsoft.Data.SqlClient;
using System.Data;

Console.WriteLine("Hello, World!");

AdoDotNetService service = new AdoDotNetService();
service.Read();
service.Create();
service.Update();
service.Delete();


Console.ReadLine();
