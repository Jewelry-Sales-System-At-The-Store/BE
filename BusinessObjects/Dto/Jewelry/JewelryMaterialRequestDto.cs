namespace BusinessObjects.Dto.Jewelry;

public class JewelryMaterialRequestDto
{
    public required string GemId { get; set; }
    public required string GoldId { get; set; }
    
    public required float GoldQuantity { get; set; }
    public required float GemQuantity { get; set; }
}