using System;
using System.Collections.Generic;

namespace EFCoreAssignment.Database.EFcoreDbContextModels;

public partial class Announcement
{
    public int AnnouncementId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? PublishDate { get; set; }

    public bool? IsActive { get; set; }
}
