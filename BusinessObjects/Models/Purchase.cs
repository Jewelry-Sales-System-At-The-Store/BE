using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class Purchase
{
    public int PurchaseId { get; set; }

    public int? CustomerId { get; set; }

    public int? UserId { get; set; }

    public int? JewelryId { get; set; }

    public DateOnly? PurchaseDate { get; set; }

    public double? PurchasePrice { get; set; }

    public int? IsBuyBack { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Jewelry? Jewelry { get; set; }
    [JsonIgnore]
    public virtual User? User { get; set; }
}
