using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Bill
{
    public int BillId { get; set; }

    public int? CustomerId { get; set; }

    public int? UserId { get; set; }

    public double? TotalAmount { get; set; }

    public DateTime? SaleDate { get; set; }

    public virtual ICollection<BillJewelry> BillJewelries { get; set; } = new List<BillJewelry>();

    public virtual ICollection<BillPromotion> BillPromotions { get; set; } = new List<BillPromotion>();

    public virtual Customer? Customer { get; set; }

    public virtual User? User { get; set; }
}
