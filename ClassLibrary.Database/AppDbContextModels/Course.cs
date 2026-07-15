using System;
using System.Collections.Generic;

namespace ClassLibrary.Database.AppDbContextModels;

public partial class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; } = null!;

    public decimal? CourseFee { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
