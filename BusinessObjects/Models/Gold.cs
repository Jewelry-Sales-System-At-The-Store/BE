using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Gold
{
    public required string GoldId { get; set; }
    public string? Type { get; set; }
    public string? City { get; set; }
    public float BuyPrice { get; set; }
    public float SellPrice { get; set; }
    
    public DateTimeOffset? LastUpdated { get; set; }
    
    public virtual IList<JewelryMaterial> JewelryMaterials { get; set; } = new List<JewelryMaterial>();
}
