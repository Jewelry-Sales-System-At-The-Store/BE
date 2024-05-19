using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class JewelryType
{
    public int JewelryTypeId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Jewelry> Jewelries { get; set; } = new List<Jewelry>();
}
