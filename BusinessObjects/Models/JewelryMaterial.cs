namespace BusinessObjects.Models;

public class JewelryMaterial
{
    public int JewelryMaterialId { get; set; }
    public int MasterPriceId { get; set; }
    public int JewelryId { get; set; }
    public int MaterialId { get; set; }
    public float Weight { get; set; }
    
    public virtual Jewelry? Jewelry { get; set; }
    public virtual Material? Material { get; set; }
    public virtual MasterPrice? MasterPrice { get; set; }
}