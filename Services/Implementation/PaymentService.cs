using BusinessObjects.Dto;
using BusinessObjects.Dto.ResponseDto;
using BusinessObjects.Models;
using Microsoft.Extensions.Configuration;
using Net.payOS;
using Net.payOS.Types;
using Repositories.Interface;
using Services.Interface;
using Tools;

namespace Services.Implementation;

public class PaymentService : IPaymentService
{
    private IConfiguration _configuration;
    private readonly PayOS _payOs;
    private readonly IPaymentRepository _paymentRepository;
    private readonly IBillRepository _billRepository;
    private readonly IBillDetailRepository _detailRepository;
    public PaymentService(IConfiguration configuration, IPaymentRepository paymentRepository, IBillRepository billRepository, IBillDetailRepository detailRepository)
    {
        _configuration = configuration;
        _paymentRepository = paymentRepository;
        _billRepository = billRepository;
        _detailRepository = detailRepository;
        _payOs = new PayOS(configuration["PayOs:ClientId"] ?? "", configuration["PayOs:ApiKey"] ?? "", configuration["PayOs:ChecksumKey"] ?? "");
    }

    public async Task<BillCheckoutResponse> CheckoutBill(string billId, PaymentRequestDto  paymentRequestDto)
    {
        var bill = await _billRepository.GetById(billId);
        if (bill == null) throw new Exception("Bill not found");
        var orderCode = Generator.GeneratePaymemtCode();

        var payment = new Payment
        {
            BillId = bill.BillId,
            PaymentId = "",
            Amount = paymentRequestDto.Amount,
            PaymentStatus = PaymentStatus.Pending,
            PaymentDate = DateTime.UtcNow.ToUniversalTime(),
            OrderCode = orderCode,
        };
        //var billPayment = _paymentRepository.GetPaymentByBillId(billId);
        //if (billPayment != null) throw new InvalidOperationException("This payment are already exist");
        var paymentResult = await _paymentRepository.Create(payment);
        if (paymentResult == null) throw new Exception("Payment failed");
        
       
        var returnUrl = paymentRequestDto.ReturnUrl;
        var cancelUrl = "";
        var description =  $"Thanh toán: ";
        var signature = "";
        
        var items = new List<ItemData>();
        var billDetails = await _detailRepository.GetBillDetail(billId);
        foreach (var item in billDetails.Items)
        {
            items.Add(new ItemData(item.Name, 1, (int)item.TotalPrice));
        }
        
        var paymentData = new PaymentData(orderCode, paymentRequestDto.Amount, description,items,cancelUrl,$"{returnUrl}/Status=Complete",signature);
        var result = await _payOs.createPaymentLink(paymentData);
        var response = new BillCheckoutResponse
        {
            CheckoutUrl = result.checkoutUrl,
            OrderCode = orderCode
        };
        return response;
    }
}