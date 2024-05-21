using BusinessObjects.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController(ICustomerService customerService) : ControllerBase
    {
        public ICustomerService CustomerService { get; } = customerService;
        [HttpGet]
        public async Task<IEnumerable<Customer?>?> GetCustomers()
        {
            return await CustomerService.GetCustomers();
        }
        [HttpGet("{id}")]
        public async Task<Customer?> GetCustomerById(int id)
        {
            return await CustomerService.GetCustomerById(id);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCustomer(Customer customer)
        {
            var result = await CustomerService.CreateCustomer(customer);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCustomer([FromQuery]int id, Customer customer)
        {
            var result = await CustomerService.UpdateCustomer(id ,customer);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var result = await CustomerService.DeleteCustomer(id);
            return Ok(result);
        }
    }
}
