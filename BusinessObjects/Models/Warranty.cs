namespace BusinessObjects.Models;

public partial class Warranty
{
    public int WarrantyId { get; set; }
    
    public int JewelryId { get; set; }

    public string? Description { get; set; }

    public DateTime? EndDate { get; set; }
    public Jewelry? Jewelry { get; set; }
}
