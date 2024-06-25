using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Customer
{
    public required string CustomerId { get; set; }

    public string? UserName { get; set; }
    
    public string? FullName { get; set; }
    
    public string? Email { get; set; }
    public string? Phone { get; set; }
    
    public string? Gender { get; set; }
    public string? Address { get; set; }
    public int? Point { get; set; }

    public DateTimeOffset CreatedAt { get; set; }
    
    public DateTimeOffset UpdatedAt { get; set; }
    
    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
}
