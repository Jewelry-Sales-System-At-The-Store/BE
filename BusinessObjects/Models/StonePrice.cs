namespace BusinessObjects.Models;

public class StonePrice
{
    public int StonePriceId { get; set; }
    public string? City { get; set; }
    public float BuyPrice { get; set; }
    public float SellPrice { get; set; }
    public string? Type { get; set; }
    public DateTime LastUpdated { get; set; }
    
    public virtual ICollection<MasterPrice> MasterPrices { get; set; } = new List<MasterPrice>();
}