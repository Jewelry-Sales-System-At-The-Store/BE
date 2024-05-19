using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class BillPromotion
{
    public int BillPromotionId { get; set; }

    public int? BillId { get; set; }

    public int? PromotionId { get; set; }

    public virtual Bill? Bill { get; set; }

    public virtual Promotion? Promotion { get; set; }
}
