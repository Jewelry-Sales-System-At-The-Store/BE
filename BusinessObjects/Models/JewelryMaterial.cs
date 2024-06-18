namespace BusinessObjects.Models;

public class JewelryMaterial
{
    public required string JewelryMaterialId { get; set; }
    public string? JewelryId { get; set; }
    
    public string? GoldPriceId { get; set; }
    
    public string? StonePriceId { get; set; }
    
    public float GoldQuantity { get; set; }
    
    public float StoneQuantity { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public virtual Gem? StonePrice { get; set; }
    public virtual Gold? GoldPrice { get; set; }
    public virtual Jewelry? Jewelry { get; set; }
}