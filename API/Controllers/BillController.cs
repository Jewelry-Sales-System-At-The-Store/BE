using BusinessObjects.DTO;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController(IBillService billService) : ControllerBase
    {
        public IBillService BillService { get; } = billService;
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var bills = await BillService.GetAll();
            return Ok(bills);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var bill = await BillService.GetById(id);
            if (bill == null)
            {
                return NotFound();
            }
            return Ok(bill);
        }
        [HttpPost]
        public async Task<IActionResult> Create(BillDTO billDto)
        {
            var bill = await BillService.Create(billDto);
            return Ok(bill);
        }
    }
}
