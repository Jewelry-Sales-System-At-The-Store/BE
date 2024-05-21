using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class Jewelry
{
    public int JewelryId { get; set; }

    public int? JewelryTypeId { get; set; }

    public int? WarrantyId { get; set; }

    public string? Name { get; set; }

    public string? Barcode { get; set; }

    public double? BasePrice { get; set; }

    public double? Weight { get; set; }

    public double? LaborCost { get; set; }

    public double? StoneCost { get; set; }

    public virtual ICollection<BillJewelry> BillJewelries { get; set; } = new List<BillJewelry>();

    public virtual JewelryType? JewelryType { get; set; }

    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    [JsonIgnore]
    public virtual Warranty? Warranty { get; set; }
}
 