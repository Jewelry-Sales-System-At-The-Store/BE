using BusinessObjects.DTO.ResponseDto;
using Microsoft.Extensions.Configuration;
using Net.payOS;
using Net.payOS.Types;
using Services.Interface;
using Tools;

namespace Services.Implementation;

public class PaymentService : IPaymentService
{
    private IConfiguration _configuration;
    private readonly PayOS _payOs;

    public PaymentService(IConfiguration configuration)
    {
        _configuration = configuration;
        _payOs = new PayOS(configuration["PayOs:ClientId"] ?? "", configuration["PayOs:ApiKey"] ?? "", configuration["PayOs:ChecksumKey"] ?? "");
    }

    public async Task<BillCheckoutResponse> CheckoutBill(string billId)
    {
        var orderCode = Generator.GeneratePaymemtCode();
        var returnUrl = "";
        var cancelUrl = "";
        var description =  $"Thanh toán: ";
        var signature = "";
        var items = new List<ItemData>();
        var paymentData = new PaymentData(orderCode, 3000, description,items,cancelUrl,returnUrl,signature);
        var result = await _payOs.createPaymentLink(paymentData);
        var response = new BillCheckoutResponse
        {
            CheckoutUrl = result.checkoutUrl,
            OrderCode = orderCode
        };
        return response;
    }
}