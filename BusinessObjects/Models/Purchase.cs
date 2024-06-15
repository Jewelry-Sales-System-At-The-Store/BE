using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class Purchase
{
    public required string PurchaseId { get; set; }

    public string? CustomerId { get; set; }

    public string? UserId { get; set; }

    public string? JewelryId { get; set; }

    public DateTimeOffset? PurchaseDate { get; set; }

    public double? PurchasePrice { get; set; }

    public int? IsBuyBack { get; set; }

    public virtual Customer? Customer { get; set; }
    public virtual Jewelry? Jewelry { get; set; }
    [JsonIgnore]
    public virtual User? User { get; set; }
}
