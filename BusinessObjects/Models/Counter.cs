using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Counter
{
    public required string CounterId { get; set; }
    public int? Number { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();
}
