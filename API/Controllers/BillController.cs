using BusinessObjects.DTO.Bill;
using BusinessObjects.DTO.BillReqRes;
using BusinessObjects.Models;
using Management.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BillController(IUserManagement userManagement) : ControllerBase
{
    private IUserManagement UserManagement { get; } = userManagement;
    
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
}
