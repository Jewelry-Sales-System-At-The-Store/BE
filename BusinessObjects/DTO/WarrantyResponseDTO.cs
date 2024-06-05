namespace BusinessObjects.DTO;

public class WarrantyResponseDTO
{
    public int WarrantyId { get; set; }
    public string? Description { get; set; }
    public DateTime? EndDate { get; set; }
    public IEnumerable<JewelryResponseDTO>? Jewelries { get; set; }
}