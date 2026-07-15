using System;
using System.Collections.Generic;

namespace ClassLibrary.Database.AppDbContextModels;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? Username { get; set; }

    public int? Age { get; set; }

    public string? Address { get; set; }
}
