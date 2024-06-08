namespace BusinessObjects.Dto.Bill
{
    public class BillRequestDto
    {
        public int? CustomerId { get; set; }
        public int? UserId { get; set; }
        public double AdditionalDiscount { get; set; }
        public IEnumerable<BillItemRequestDto?>? Jewelries { get; set; }
        public IEnumerable<BillPromotionRequestDto?>? Promotions { get; set; }
    }
}