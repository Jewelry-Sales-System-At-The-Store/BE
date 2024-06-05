using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class Jewelry
{
    public int JewelryId { get; set; }
    public int JewelryTypeId { get; set; }
    
    public string? Name { get; set; }

    public string? Barcode { get; set; }
    
    public double? LaborCost { get; set; }
    public bool? IsSold { get; set; }
    public virtual ICollection<BillJewelry> BillJewelries { get; set; } = new List<BillJewelry>();
    public virtual JewelryType? JewelryType { get; set; }
    public virtual Warranty? Warranty { get; set; }
    public virtual ICollection<JewelryMaterial> JewelryMaterials { get; set; } = new List<JewelryMaterial>();
    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
}
 