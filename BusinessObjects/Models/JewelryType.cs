using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class JewelryType
{
    public int JewelryTypeId { get; set; }

    public string? Name { get; set; }
    [JsonIgnore]
    public virtual ICollection<Jewelry> Jewelries { get; set; } = new List<Jewelry>();
}
