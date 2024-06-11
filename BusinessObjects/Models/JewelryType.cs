using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Tools;

namespace BusinessObjects.Models;

public partial class JewelryType
{
    public JewelryType()
    {
        JewelryTypeId = IdGenerator.GenerateId();
    }
    public required string JewelryTypeId { get; set; }

    public string? Name { get; set; }
    public virtual ICollection<Jewelry> Jewelries { get; set; } = new List<Jewelry>();
}
