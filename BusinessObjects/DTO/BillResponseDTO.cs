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
        public IEnumerable<JewelryResponseDTO?>? Jewelries { get; set; }
    }
}