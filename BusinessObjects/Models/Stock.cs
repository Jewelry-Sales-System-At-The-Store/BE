using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Stock
{
    public string? StockId { get; set; }

    public string StockCode { get; set; } = null!;

    public string? StockName { get; set; }

    public string? CompanyName { get; set; }

    public string? Email { get; set; }

    public string? Exchange { get; set; }

    public string? Address { get; set; }

    public int? CurrentPrice { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<StocksHistory> StocksHistories { get; set; } = new List<StocksHistory>();
}
