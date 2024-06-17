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

public class Materials
{
    public GoldResponseDto? Gold { get; set; }
    public GemResponseDto? Gem { get; set; }
}

public class GoldResponseDto
{
    public string? GoldType { get; set; }
    public float? GoldQuantity { get; set; }
    public float? GoldPrice { get; set; }
}

public class GemResponseDto
{
    public string? Gem { get; set; }
    public float? GemQuantity { get; set; }
    public float? GemPrice { get; set; }
}