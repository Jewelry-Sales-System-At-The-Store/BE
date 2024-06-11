namespace BusinessObjects.Models;

public class MasterPrice
{
    public required string MasterPriceId { get; set; }
    public string? StonePriceId { get; set; }
    public string? GoldPriceId { get; set; }
    
    public float GoldStorePrice { get; set; }
    
    public float StoneStorePrice { get; set; }
    
    public virtual StonePrice? StonePrice { get; set; }
    public virtual GoldPrice? GoldPrice { get; set; }
    
}