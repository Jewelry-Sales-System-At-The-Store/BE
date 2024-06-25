namespace BusinessObjects.DTO.Jewelry;

public class JewelryRequestDto
{
    public string? JewelryTypeId { get; set; }
    
    public string? Name { get; set; }
    
    public JewelryMaterialRequestDto? JewelryMaterial { get; set; }

    public string? Barcode { get; set; }
    
    public double? LaborCost { get; set; }
}