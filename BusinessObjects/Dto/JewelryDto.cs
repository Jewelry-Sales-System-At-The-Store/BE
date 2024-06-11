namespace BusinessObjects.Dto;

public class JewelryDto
{
    public string? JewelryTypeId { get; set; }
    
    public string? Name { get; set; }

    public string? Barcode { get; set; }
    
    public double? LaborCost { get; set; }
    
    public bool? IsSold { get; set; }
}