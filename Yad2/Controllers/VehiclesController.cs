using Microsoft.AspNetCore.Mvc;
using Yad2.Core.Entities;
using Yad2.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yad2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {

        private readonly VehicleService _vehicleService;
        public VehiclesController(VehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }
        // GET: api/<VehiclesController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_vehicleService.GetAllVehicles());
        }

        // GET api/<VehiclesController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_vehicleService.GetVehicleById(id));
        }

        // POST api/<VehiclesController>
        [HttpPost]
        public ActionResult Post([FromBody] Vehicle vehicle)
        {
            return Ok(_vehicleService.AddVehicle(vehicle));
        }

        // PUT api/<VehiclesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Vehicle vehicle)
        {
            _vehicleService.UpdateVehicle(id, vehicle);
            return Ok();
        }

        // DELETE api/<VehiclesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _vehicleService.DeleteVehicle(id);
            return Ok();
        }
    }
}
