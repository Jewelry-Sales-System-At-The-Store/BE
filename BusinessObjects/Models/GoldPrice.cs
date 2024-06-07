using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class GoldPrice
{
    public int GoldPriceId { get; set; }
    public string? City { get; set; }
    public float BuyPrice { get; set; }
    public float SellPrice { get; set; }
    public string? Type { get; set; }
    
    public DateTime LastUpdated { get; set; }
    
    public virtual ICollection<MasterPrice> MasterPrices { get; set; } = new List<MasterPrice>();
}
