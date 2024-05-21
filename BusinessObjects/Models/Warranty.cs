using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Warranty
{
    public int WarrantyId { get; set; }

    public string? Description { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual ICollection<Jewelry> Jewelries { get; set; } = new List<Jewelry>();
}
