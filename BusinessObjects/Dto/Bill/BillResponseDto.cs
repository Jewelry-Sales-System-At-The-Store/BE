namespace BusinessObjects.Dto.Bill
{
    public class BillResponseDto
    {
        public int BillId { get; set; }
        public double TotalAmount { get; set; }
        public DateTime? SaleDate { get; set; }
        public required List<BillItemResponse?> Items { get; set; }
        public required List<BillPromotionResponse?> Promotions { get; set; }
        public double AdditionalDiscount { get; set; }
        public int PointsUsed { get; set; }
        public double FinalAmount { get; set; }
    }
}