using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Yad2.Core.Entities;
using Yad2.Service;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yad2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
<<<<<<< HEAD
        private readonly CustomerService _customerService;
        public CustomersController(CustomerService customerService)
        {
            _customerService = customerService;
        }


=======
        private readonly DataContext _context;
        static int cnt = 0;
        public CustomersController(DataContext context)
        {
            _context = context;
        }
>>>>>>> 33e520dbbcce61cb230cf00b90ff116e5de8e5fc
        // GET: api/<CustomersController>
        [HttpGet]
        public ActionResult Get()
        {
<<<<<<< HEAD
            return Ok(_customerService.GetAllCustomers());
=======
            return _context.CustomersList;
>>>>>>> 33e520dbbcce61cb230cf00b90ff116e5de8e5fc
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
<<<<<<< HEAD
            return Ok( _customerService.GetCustomerById(id));
            
=======
            var customer = _context.CustomersList.Find(x => x.Id == id);
            if(customer == null)
            {
                return NotFound();
            }
            return customer;
>>>>>>> 33e520dbbcce61cb230cf00b90ff116e5de8e5fc
        }

        // POST api/<CustomersController>
        [HttpPost]
        public ActionResult Post([FromBody] Customer customer)
        {
<<<<<<< HEAD
            return Ok(_customerService.AddCustomer(customer));
=======
            cnt++;
            _context.CustomersList.Add(new Customer { Id=cnt,Name=customer.Name,Phone=customer.Phone,Email=customer.Email});
            
>>>>>>> 33e520dbbcce61cb230cf00b90ff116e5de8e5fc
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customer customer)
        {
<<<<<<< HEAD
            _customerService.UpdateCustomer(id, customer);

=======
            var cus = _context.CustomersList.Find(c => c.Id == id);
            if (cus != null)
            {
                cus.Name = customer.Name;
                cus.Phone = customer.Phone;
                cus.Email = customer.Email;
            }
            
>>>>>>> 33e520dbbcce61cb230cf00b90ff116e5de8e5fc
            return Ok();
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
<<<<<<< HEAD
            _customerService.DeleteCustomer(id);
=======
            var cus = _context.CustomersList.Find(c => c.Id == id);
            if (cus != null)
            {
                _context.CustomersList.Remove(cus);
                
            }
            
>>>>>>> 33e520dbbcce61cb230cf00b90ff116e5de8e5fc
            return Ok();
        }
    }
}
