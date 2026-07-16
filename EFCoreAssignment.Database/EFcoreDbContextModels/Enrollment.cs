using System;
using System.Collections.Generic;

namespace EFCoreAssignment.Database.EFcoreDbContextModels;

public partial class Enrollment
{
    public int EnrollmentId { get; set; }

    public int StudentId { get; set; }

    public int CourseId { get; set; }

    public DateOnly? EnrollmentDate { get; set; }
}
