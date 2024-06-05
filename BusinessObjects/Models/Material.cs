namespace BusinessObjects.Models;

public class Material
{
    public int MaterialId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    
    public virtual ICollection<JewelryMaterial> JewelryMaterials { get; set; } = new List<JewelryMaterial>();
}