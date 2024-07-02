namespace BusinessObjects.Dto.BillReqRes;

public class BillCashCheckoutResponseDto
{
    public required string BillId { get; set; }
    public float InitialAmount { get; set; }
    public float CashBack { get; set; }
    
    public string? Status { get; set; }
}