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

        private readonly MediatorService _mediatorService;

        public MediatorsController(MediatorService mediatorService)
        {
            _mediatorService = mediatorService;

        }
        // GET: api/<MediatorsController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_mediatorService.GetAllMediators());
        }

        // GET api/<MediatorsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_mediatorService.GetMediatorById(id));
        }

        // POST api/<MediatorsController>
        [HttpPost]
        public ActionResult Post([FromBody] Mediator mediator)
        {
            return Ok(_mediatorService.AddMediator(mediator));
        }

        // PUT api/<MediatorsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Mediator mediator)
        {
            _mediatorService.UpdateMediator(id, mediator);
            return Ok();
        }

        // DELETE api/<MediatorsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _mediatorService.DeleteMediator(id);
            return Ok();
        }
    }
}
