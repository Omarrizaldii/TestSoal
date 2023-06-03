using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SoalNo3MembuatAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public static List<Customer> customers = new List<Customer>
        {
            new Customer{ Id = 1,Nama="Omar",Address = "Tangerang"},
            new Customer{ Id = 2,Nama="Karin",Address = "Jakarta"},
        };

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetCustomer()
        {
            return Ok(customers);
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> CreateCustomer(Customer customer)
        {
            customers.Add(customer);
            return Ok(customers);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCustomer(int id)
        {
            var customer = customers.Where(s => s.Id == id).FirstOrDefault();
            if (customer == null)
                return NotFound("Customer not found");
            customers.Remove(customer);
            return Ok(customers);
        }
    }
}