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
        private static List <Customer> _customers=new List<Customer> ();
        static int cnt = 1;
        // GET: api/<CustomersController>
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            return _customers;
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            var customer = _customers.Find(x => x.Id == id);
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
            _customers.Add(new Customer { Id=cnt,Name=customer.Name,Phone=customer.Phone,Email=customer.Email});
            cnt++;
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customer customer)
        {
            var cus = _customers.Find(c => c.Id == id);
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
            var cus = _customers.Find(c => c.Id == id);
            if (cus != null)
            {
                _customers.Remove(cus);
                cnt--;
            }
            
            return Ok();
        }
    }
}
