namespace BusinessObjects.DTO.ResponseDto;

public class BillCheckoutResponse
{
    public string? CheckoutUrl { get; set; }
    public string? BillId { get; set; }
    public long OrderCode { get; set; }
}