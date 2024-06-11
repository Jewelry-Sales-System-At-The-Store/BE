using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Promotion
{
    public required string PromotionId { get; set; }

    public string? Type { get; set; }

    public string? ApproveManager { get; set; }

    public string? Description { get; set; }

    public double? DiscountRate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual ICollection<BillPromotion> BillPromotions { get; set; } = new List<BillPromotion>();
}
