using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Yad2.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yad2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly DataContext _context;
        static int cnt = 0;
        public CustomersController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<CustomersController>
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            return _context.CustomersList;
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            var customer = _context.CustomersList.Find(x => x.Id == id);
            if(customer == null)
            {
                return NotFound();
            }
            return customer;
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            cnt++;
            _context.CustomersList.Add(new Customer { Id=cnt,Name=customer.Name,Phone=customer.Phone,Email=customer.Email});
            
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customer customer)
        {
            var cus = _context.CustomersList.Find(c => c.Id == id);
            if (cus != null)
            {
                cus.Name = customer.Name;
                cus.Phone = customer.Phone;
                cus.Email = customer.Email;
            }
            
            return Ok();
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var cus = _context.CustomersList.Find(c => c.Id == id);
            if (cus != null)
            {
                _context.CustomersList.Remove(cus);
                
            }
            
            return Ok();
        }
    }
}
