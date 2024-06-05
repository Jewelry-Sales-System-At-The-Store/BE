namespace BusinessObjects.Models;

public class MasterPrice
{
    public int MasterPriceId { get; set; }
    public int StonePriceId { get; set; }
    public int GoldPriceId { get; set; }
    public float SellOutPrice { get; set; }
    public DateTime Date { get; set; }
    
    public virtual StonePrice? StonePrice { get; set; }
    public virtual GoldPrice? GoldPrice { get; set; }
    public virtual ICollection<JewelryMaterial>? JewelryMaterials { get; set; }
}