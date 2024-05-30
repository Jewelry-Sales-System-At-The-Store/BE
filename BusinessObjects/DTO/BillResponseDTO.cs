namespace BusinessObjects.DTO
{
    public class BillResponseDTO
    {
        public int? BillId { get; set; }
        public int? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public int? UserId { get; set; }
        public double? TotalAmount { get; set; }
        public DateTime? SaleDate { get; set; }
        public IEnumerable<JewelryResponse?>? Jewelries { get; set; }
    }
    public class JewelryResponse
    {
        public int JewelryId { get; set; }
        public string? Name { get; set; }
        public string? Barcode { get; set; }
        public double? BasePrice { get; set; }
        public double? Weight { get; set; }
        public double? LaborCost { get; set; }
        public double? StoneCost { get; set; }
        public WarrantyResponse? Warranty { get; set; }
        public JewelryTypeResponse? JewelryType { get; set; }
    }
    public class WarrantyResponse
    {
        public int WarrantyId { get; set; }
        public string? Description { get; set; }
        public DateTime? EndDate { get; set; }
    }
    public class JewelryTypeResponse
    {
        public int? JewelryTypeId { get; set; }
        public string? Name { get; set; }
    }
}