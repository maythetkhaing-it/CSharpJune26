// See https://aka.ms/new-console-template for more information
using EFCoreAssignment.Database.EFcoreDbContextModels;

//Console.WriteLine("Hello, World!");
//Students
EFcoreDbContext db = new EFcoreDbContext();
//var lst = db.Students.ToList();

//foreach (var item in lst)
//{
//    Console.WriteLine(item.StudentId);
//    Console.WriteLine(item.StudentName);
//    Console.WriteLine("===========");

//}

//Enrollemnts
//var enrollment = db.Enrollments.ToList();
//foreach(var item in enrollment)
//{
//    Console.WriteLine(item.EnrollmentId);
//    Console.WriteLine(item.EnrollmentDate);
//    Console.WriteLine("===============");
//}

//List<Student> lst = db.Students.ToList();

//foreach (var item in lst)
//{
//    Console.WriteLine(item.StudentId);
//    Console.WriteLine(item.StudentName);
//    Console.WriteLine("===========");
//}

//Announcements
var lst = db.Announcements.ToList();

foreach (var item in lst)
{
    Console.WriteLine(item.AnnouncementId);
    Console.WriteLine(item.Title);
    Console.WriteLine("=========");
}
//After completing all three steps, EF Core Scaffold is still working successfully.
//This proves that even after creating and dropping tables, EF Core can re-scaffold the database and generate updated DbContext and model classes.