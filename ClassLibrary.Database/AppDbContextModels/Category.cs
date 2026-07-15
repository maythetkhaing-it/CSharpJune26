using System;
using System.Collections.Generic;

namespace ClassLibrary.Database.AppDbContextModels;

public partial class Category
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
