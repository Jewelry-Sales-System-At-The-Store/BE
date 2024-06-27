using BusinessObjects.DTO.Bill;
using Management.Interface;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

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
    [HttpGet("CheckoutBill/{id}")]
    public async Task<IActionResult> Checkout(string id)
    {
        return Ok(await PaymentService.CheckoutBill(id));
    }
}
