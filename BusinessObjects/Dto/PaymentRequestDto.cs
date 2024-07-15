namespace BusinessObjects.Dto;

public class PaymentRequestDto
{
    public int CustomerId { get; set; }
    public int BillId { get; set; }
    public int Amount { get; set; }
    public string? RedirectUrl { get; set; }
}