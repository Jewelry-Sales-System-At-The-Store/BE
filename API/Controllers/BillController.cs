using BusinessObjects.Dto;
using BusinessObjects.Dto.BillReqRes;
using BusinessObjects.Models;
using Management.Interface;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using Snappier;
using Tools;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BillController(IUserManagement userManagement, IPaymentService paymentService) : ControllerBase
{
    private IUserManagement UserManagement { get; } = userManagement;
    private IPaymentService PaymentService { get; } = paymentService;

    [HttpGet("GetBills")]
    public async Task<IActionResult> Get(int pageNumber, int pageSize)
    {
        var bills = await UserManagement.GetBills(pageNumber, pageSize);
        return Ok(bills);
    }
    [HttpGet("GetBillById/{id}")]
    public async Task<IActionResult> Get(string id)
    {
        var bill = await UserManagement.GetBillById(id);
        if (bill == null) return NotFound();
        return Ok(bill);
    }
    [HttpPost("CreateBill")]
    public async Task<IActionResult> Create(BillRequestDto billRequestDto)
    {
        return Ok(await UserManagement.CreateBill(billRequestDto));
    }
    [HttpPost("CheckoutOnline/{billId}")]
    public async Task<IActionResult> CheckoutOnline(string billId,PaymentRequestDto paymentRequestDto)
    {
        var orderCode = Generator.GeneratePaymemtCode();
        var cancelUrl = Url.Action("CancelPayment","Bill",new {paymentRequestDto.ReturnUrl,orderCode},Request.Scheme);
        var suscessUrl = Url.Action("SuccessPayment","Bill",new {billId,paymentRequestDto.ReturnUrl,orderCode},Request.Scheme);
        return Ok(await PaymentService.CheckoutBill(billId,paymentRequestDto.Amount,orderCode,suscessUrl,cancelUrl));
    }

    [HttpPost("CheckoutOffline/{id}")]
    public async Task<IActionResult> CheckoutOffline(string id, float cashAmount)
    {
        return Ok(await UserManagement.CheckoutBill(id,cashAmount));
    }

    [HttpGet("CancelPayment")]
    public async Task<IActionResult> CancelPayment(string returnUrl,long orderCode)
    {
        await paymentService.UpdatePaymentStatus(orderCode, PaymentStatus.Failed);
        return Redirect($"{returnUrl}/status=canceled");
    }
    [HttpGet("SuccessPayment")]
    public async Task<IActionResult> SuccessPayment(string billId,string returnUrl,long orderCode)
    {
        await paymentService.UpdatePaymentStatus(orderCode, PaymentStatus.Success);
        await paymentService.UpdateBillStatus(billId);
        await paymentService.UpdateJewelryStatus(billId);
        return Redirect($"{returnUrl}/status=success");
    }
}
