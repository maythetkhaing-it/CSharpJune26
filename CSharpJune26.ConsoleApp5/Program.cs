// See https://aka.ms/new-console-template for more information
using ClassLibrary.Database.AppDbContextModels;
using CSharpJune26.ConsoleApp5;

Console.WriteLine("Hello, World!");


ConsoleAppDbContext db = new ConsoleAppDbContext();

//CRUD
//Read

//LINQ
//var lst = db.Employees.ToList();

//foreach(var item in lst)
//{
//    Console.WriteLine(item.employeeID);
//    Console.WriteLine(item.username);
//    Console.WriteLine("===========");
//}

// var employee = db.Employees.Where(x => x.employeeID == 1).FirstOrDefault();
// var employee2 = db.Employees.Where(x => x.employeeID == 10).FirstOrDefault();

//Insert
//EmployeeEntity employee = new EmployeeEntity()
//{
//    username = "Tun Tun"
//};

// db.Employees.Add(employee);

//Update
//var employee = db.Employees.Where(x => x.employeeID == 5).FirstOrDefault();
//if(employee is null)
//{
//    Console.WriteLine("Employee is not found!");
//}
//else
//{
//    // employee.username = "Mg Mg";
//    employee.address = "Yangon";
//    int result = db.SaveChanges();
//}

//Delete
var employee3 = db.Employees.Where(x => x.employeeID == 5).FirstOrDefault();
if(employee3 is null)
{
    Console.WriteLine("Employee is not found!");
}

db.Employees.Remove(employee3);
int result = db.SaveChanges();



AppDbContext db2 = new AppDbContext();
var lst2 = db2.Employees.ToList();
var lst3 = db2.Students.ToList();

Console.ReadLine();