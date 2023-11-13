using Microsoft.AspNetCore.Mvc;
using Yad2.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yad2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediatorsController : ControllerBase
    {
        private readonly DataContext _context;
        static int cnt = 0;
        public MediatorsController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<MediatorsController>
        [HttpGet]
        public ActionResult<IEnumerable<Mediator>> Get()
        {
            return _context.MediatorsList;
        }

        // GET api/<MediatorsController>/5
        [HttpGet("{id}")]
        public ActionResult<Mediator> Get(int id)
        {
            var mediator = _context.MediatorsList.Find(x => x.Id == id);
            if (mediator == null)
            {
                return NotFound();
            }
            return mediator;
        }

        // POST api/<MediatorsController>
        [HttpPost]
        public void Post([FromBody] Mediator mediator)
        {
            cnt++;
            _context.MediatorsList.Add(new Mediator { Id=cnt,Name=mediator.Name,Seniority=mediator.Seniority,Commission=mediator.Commission,NumDeals=mediator.NumDeals});
            
        }

        // PUT api/<MediatorsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Mediator mediator)
        {
            var med = _context.MediatorsList.Find(x => x.Id == id);
            if (med != null)
            {
                med.Name = mediator.Name;
                med.Seniority = mediator.Seniority;
                med.Commission = mediator.Commission;
                med.NumDeals = mediator.NumDeals;
            }

            return Ok();
        }

        // DELETE api/<MediatorsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var med = _context.MediatorsList.Find(x => x.Id == id);
            if (med != null)
            {
                _context.MediatorsList.Remove(med);
                
            }

            return Ok();
        }
    }
}
