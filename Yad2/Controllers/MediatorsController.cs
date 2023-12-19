using Microsoft.AspNetCore.Mvc;
using Yad2.Core.Entities;
using Yad2.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yad2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediatorsController : ControllerBase
    {
<<<<<<< HEAD
        private readonly MediatorService _mediatorService;

        public MediatorsController(MediatorService mediatorService)
        {
            _mediatorService = mediatorService;
=======
        private readonly DataContext _context;
        static int cnt = 0;
        public MediatorsController(DataContext context)
        {
            _context = context;
>>>>>>> 33e520dbbcce61cb230cf00b90ff116e5de8e5fc
        }
        // GET: api/<MediatorsController>
        [HttpGet]
        public ActionResult Get()
        {
<<<<<<< HEAD
            return Ok(_mediatorService.GetAllMediators());
=======
            return _context.MediatorsList;
>>>>>>> 33e520dbbcce61cb230cf00b90ff116e5de8e5fc
        }

        // GET api/<MediatorsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
<<<<<<< HEAD
            return Ok(_mediatorService.GetMediatorById(id));
=======
            var mediator = _context.MediatorsList.Find(x => x.Id == id);
            if (mediator == null)
            {
                return NotFound();
            }
            return mediator;
>>>>>>> 33e520dbbcce61cb230cf00b90ff116e5de8e5fc
        }

        // POST api/<MediatorsController>
        [HttpPost]
        public ActionResult Post([FromBody] Mediator mediator)
        {
<<<<<<< HEAD
            
            return Ok(_mediatorService.AddMediator(mediator));
=======
            cnt++;
            _context.MediatorsList.Add(new Mediator { Id=cnt,Name=mediator.Name,Seniority=mediator.Seniority,Commission=mediator.Commission,NumDeals=mediator.NumDeals});
            
>>>>>>> 33e520dbbcce61cb230cf00b90ff116e5de8e5fc
        }

        // PUT api/<MediatorsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Mediator mediator)
        {
<<<<<<< HEAD
           
            _mediatorService.UpdateMediator(id, mediator);
=======
            var med = _context.MediatorsList.Find(x => x.Id == id);
            if (med != null)
            {
                med.Name = mediator.Name;
                med.Seniority = mediator.Seniority;
                med.Commission = mediator.Commission;
                med.NumDeals = mediator.NumDeals;
            }

>>>>>>> 33e520dbbcce61cb230cf00b90ff116e5de8e5fc
            return Ok();
        }

        // DELETE api/<MediatorsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
<<<<<<< HEAD
            _mediatorService.DeleteMediator(id);
=======
            var med = _context.MediatorsList.Find(x => x.Id == id);
            if (med != null)
            {
                _context.MediatorsList.Remove(med);
                
            }
>>>>>>> 33e520dbbcce61cb230cf00b90ff116e5de8e5fc

            return Ok();
        }
    }
}
