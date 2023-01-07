using System;
using System.Collections.Generic;

namespace Core.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Sku { get; set; }

    public string? Description { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }
}
