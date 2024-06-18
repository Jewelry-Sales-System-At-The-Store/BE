using BusinessObjects.Models;

namespace BusinessObjects.DTO.ResponseDto;

public class JewelryResponseDto
{
    public string? JewelryId { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public string? Barcode { get; set; }
    public double? LaborCost { get; set; }
    public float JewelryPrice { get; set; }
    public IList<Materials>? Materials { get; set; }
    public float TotalPrice { get; set; }
}