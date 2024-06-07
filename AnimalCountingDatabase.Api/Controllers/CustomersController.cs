using AnimalCountingDatabase.Api.Migrations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnimalCountingDatabase.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController(CustomerContext context) : ControllerBase
    {

        [HttpGet]
        public async Task<IEnumerable<Customer>> GetAll() 
            => await context.Customers.ToArrayAsync();

        [HttpPost] 
        public async Task<Customer> Add([FromBody]Customer c)
        {
            context.Customers.Add(c);
            await context.SaveChangesAsync();
            return c;
        }
    }
}
