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
        private readonly CustomerService _customerService;
        public CustomersController(CustomerService customerService)
        {
            _customerService = customerService;
        }


        // GET: api/<CustomersController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_customerService.GetAllCustomers());
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok( _customerService.GetCustomerById(id));
            
        }

        // POST api/<CustomersController>
        [HttpPost]
        public ActionResult Post([FromBody] Customer customer)
        {
            return Ok(_customerService.AddCustomer(customer));
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customer customer)
        {
            _customerService.UpdateCustomer(id, customer);

            return Ok();
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _customerService.DeleteCustomer(id);
            return Ok();
        }
    }
}
