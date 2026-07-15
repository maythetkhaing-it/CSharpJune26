using System;
using System.Collections.Generic;

namespace ClassLibrary.Database.AppDbContextModels;

public partial class User
{
    public string UserId { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string? Phone { get; set; }

    public int Age { get; set; }

    public string? Address { get; set; }

    public decimal? UserBalance { get; set; }
}
