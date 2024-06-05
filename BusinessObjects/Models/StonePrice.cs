namespace BusinessObjects.Models;

public class StonePrice
{
    public int StonePriceId { get; set; }
    public string? City { get; set; }
    public decimal BuyPrice { get; set; }
    public decimal SellPrice { get; set; }
    public string? Type { get; set; }
    public DateTime LastUpdated { get; set; }
    
    public virtual ICollection<MasterPrice> MasterPrices { get; set; } = new List<MasterPrice>();
}