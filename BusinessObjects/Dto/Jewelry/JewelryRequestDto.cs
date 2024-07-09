﻿namespace BusinessObjects.Dto.Jewelry;

public class JewelryRequestDto
{
    public string? JewelryTypeId { get; set; }
    
    public string? Name { get; set; }
    public string? ImageUrl { get; set; }
    
    public JewelryMaterialRequestDto? JewelryMaterial { get; set; }

    public string? Barcode { get; set; }
    
    public double? LaborCost { get; set; }
}