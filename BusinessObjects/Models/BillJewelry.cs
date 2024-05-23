using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class BillJewelry
{
    public int BillJewelryId { get; set; }

    public int? BillId { get; set; }

    public int? JewelryId { get; set; }

    public virtual Bill? Bill { get; set; }

    public virtual Jewelry? Jewelry { get; set; }
}
