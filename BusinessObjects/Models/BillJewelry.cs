using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class BillJewelry
{
    public required string BillJewelryId { get; set; }

    public string? BillId { get; set; }

    public string? JewelryId { get; set; }

    public virtual Bill? Bill { get; set; }

    public virtual Jewelry? Jewelry { get; set; }
}
