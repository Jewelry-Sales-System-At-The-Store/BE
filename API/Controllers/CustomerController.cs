using BusinessObjects.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController(ICustomerService customerService) : ControllerBase
{
    private ICustomerService CustomerService { get; } = customerService;
    [HttpGet]
    public async Task<IEnumerable<Customer?>?> GetCustomers()
    {
        return await CustomerService.GetCustomers();
    }
    [HttpGet("GetCustomerById/{id:int}")]
    public async Task<Customer?> GetCustomerById(int id)
    {
        return await CustomerService.GetCustomerById(id);
    }
    [HttpPost("CreateCustomer")]
    public async Task<IActionResult> CreateCustomer(Customer customer)
    {
        var result = await CustomerService.CreateCustomer(customer);
        return Ok(result);
    }
    [HttpPut("UpdateCustomer/{id:int}")]
    public async Task<IActionResult> UpdateCustomer(int id, Customer customer)
    {
        var result = await CustomerService.UpdateCustomer(id ,customer);
        return Ok(result);
    }
    [HttpDelete("DeleteCustomer/{id:int}")]
    public async Task<IActionResult> DeleteCustomer(int id)
    {
        var result = await CustomerService.DeleteCustomer(id);
        return Ok(result);
    }
}
