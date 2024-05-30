using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class GoldPrice
{
    public int Id { get; set; }
    public string? City { get; set; }
    public decimal BuyPrice { get; set; }
    public decimal SellPrice { get; set; }
    public string? Type { get; set; }
    public DateTime LastUpdated { get; set; }
}
