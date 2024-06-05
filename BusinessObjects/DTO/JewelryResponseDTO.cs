namespace BusinessObjects.DTO;

public class JewelryResponseDTO
{
    public int JewelryId { get; set; }
    public string? Name { get; set; }
    public string? Barcode { get; set; }
    public double? BasePrice { get; set; }
    public double? Weight { get; set; }
    public double? LaborCost { get; set; }
    public double? StoneCost { get; set; }
    public WarrantyResponseDTO? Warranty { get; set; }
    public JewelryTypeResponseDTO? JewelryType { get; set; }
}