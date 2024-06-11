using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class BillPromotion
{
    public required string BillPromotionId { get; set; }

    public string? BillId { get; set; }

    public string? PromotionId { get; set; }

    public virtual Bill? Bill { get; set; }

    public virtual Promotion? Promotion { get; set; }
}
