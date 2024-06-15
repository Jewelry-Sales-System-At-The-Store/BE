using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class GoldPrice
{
    public required string GoldPriceId { get; set; }
    public string? Type { get; set; }
    public string? City { get; set; }
    public float BuyPrice { get; set; }
    public float SellPrice { get; set; }
   
    public DateTimeOffset? LastUpdated { get; set; }
    
    public virtual ICollection<JewelryMaterial> JewelryMaterials { get; set; } = new List<JewelryMaterial>();
    public virtual ICollection<MasterPrice> MasterPrices { get; set; } = new List<MasterPrice>();
}
