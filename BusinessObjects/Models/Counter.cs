using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Counter
{
    public int CounterId { get; set; }
    public int? Number { get; set; }
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
