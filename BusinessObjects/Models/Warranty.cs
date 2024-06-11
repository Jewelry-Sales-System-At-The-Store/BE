namespace BusinessObjects.Models;

public partial class Warranty
{
    public required string WarrantyId { get; set; }
    
    public string? JewelryId { get; set; }

    public string? Description { get; set; }

    public DateTime? EndDate { get; set; }
    public Jewelry? Jewelry { get; set; }
}
