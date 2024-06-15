using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class Bill
{
    public required string BillId { get; set; }

    public string? CustomerId { get; set; }

    public string? UserId { get; set; }
    
    public string? CounterId { get; set; }

    public double? TotalAmount { get; set; }

    public DateTimeOffset? SaleDate { get; set; }
    public virtual ICollection<BillJewelry> BillJewelries { get; set; } = new List<BillJewelry>();
    public virtual ICollection<BillPromotion> BillPromotions { get; set; } = new List<BillPromotion>();

    public virtual Customer? Customer { get; set; }

    public virtual User? User { get; set; }
    
    public virtual Counter? Counter { get; set; }
}
