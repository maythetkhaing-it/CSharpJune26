using System;
using System.Collections.Generic;

namespace EFCoreAssignment.Database.EFcoreDbContextModels;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public string? Gender { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }
}
