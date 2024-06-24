using BusinessObjects.DTO.ResponseDto;

namespace Services.Interface;

public interface IPaymentService
{
    Task<BillCheckoutResponse> CheckoutBill(string billId);
}