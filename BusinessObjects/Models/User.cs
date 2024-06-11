namespace BusinessObjects.Models;

public partial class User
{
    public required string UserId { get; set; }

    public string? RoleId { get; set; }

    public string? CounterId { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
    
    public bool Status { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();
    public virtual Counter? Counter { get; set; }

    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    public virtual Role? Role { get; set; }
}
