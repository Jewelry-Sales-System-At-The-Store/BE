namespace BusinessObjects.Models;

public partial class Warranty
{
    public required string WarrantyId { get; set; }
    
    public string? JewelryId { get; set; }

    public string? Description { get; set; }

    public DateTimeOffset? EndDate { get; set; }
    public Jewelry? Jewelry { get; set; }
}
