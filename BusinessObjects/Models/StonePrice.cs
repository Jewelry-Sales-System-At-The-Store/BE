namespace BusinessObjects.Models;

public class StonePrice
{
    public required string StonePriceId { get; set; }
    public string? Type { get; set; }
    public string? City { get; set; }
    public float BuyPrice { get; set; }
    public float SellPrice { get; set; }
    
    public DateTime LastUpdated { get; set; }
    
    public virtual ICollection<JewelryMaterial> JewelryMaterials { get; set; } = new List<JewelryMaterial>();
    public virtual ICollection<MasterPrice> MasterPrices { get; set; } = new List<MasterPrice>();
}