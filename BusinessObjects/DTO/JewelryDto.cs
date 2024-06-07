namespace BusinessObjects.DTO;

public class JewelryDto
{
    public int JewelryTypeId { get; set; }
    
    public string? Name { get; set; }

    public string? Barcode { get; set; }
    
    public double? LaborCost { get; set; }
    
    public bool? IsSold { get; set; }
}