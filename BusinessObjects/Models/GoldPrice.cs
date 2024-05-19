using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class GoldPrice
{
    public int GoldPriceId { get; set; }

    public DateTime? Date { get; set; }

    public double? PricePerGram { get; set; }
}
