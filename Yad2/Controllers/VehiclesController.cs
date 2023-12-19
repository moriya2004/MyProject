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
<<<<<<< HEAD

        private readonly VehicleService _vehicleService;
        public VehiclesController(VehicleService vehicleService)
        {
            _vehicleService = vehicleService;
=======
        
        private readonly DataContext _context;
        static int cnt = 0;
        public VehiclesController(DataContext context)
        {
            _context = context;
>>>>>>> 33e520dbbcce61cb230cf00b90ff116e5de8e5fc
        }
        // GET: api/<VehiclesController>
        [HttpGet]
        public ActionResult Get()
        {
<<<<<<< HEAD
            return Ok(_vehicleService.GetAllVehicles());
=======
            return _context.VehiclesList;
>>>>>>> 33e520dbbcce61cb230cf00b90ff116e5de8e5fc
        }

        // GET api/<VehiclesController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
<<<<<<< HEAD
            return Ok(_vehicleService.GetVehicleById(id));
=======
            var vehicle = _context.VehiclesList.Find(x => x.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }
            return vehicle;
>>>>>>> 33e520dbbcce61cb230cf00b90ff116e5de8e5fc
        }

        // POST api/<VehiclesController>
        [HttpPost]
        public ActionResult Post([FromBody] Vehicle vehicle)
        {
<<<<<<< HEAD
           
            
            return Ok(_vehicleService.AddVehicle(vehicle));
=======
            cnt++;
            _context.VehiclesList.Add(new Vehicle { Id=cnt,Type=vehicle.Type,Company=vehicle.Company,YearOfProduction=vehicle.YearOfProduction,Accident=vehicle.Accident,Km=vehicle.Km,Price=vehicle.Price});
            
>>>>>>> 33e520dbbcce61cb230cf00b90ff116e5de8e5fc
        }

        // PUT api/<VehiclesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Vehicle vehicle)
        {
<<<<<<< HEAD
            _vehicleService.UpdateVehicle(id, vehicle);
=======
            var vec = _context.VehiclesList.Find(x => x.Id == id);
            if(vec != null)
            {
                vec.Type = vehicle.Type;
                vec.Company = vehicle.Company;
                vec.YearOfProduction = vehicle.YearOfProduction;
                vec.Accident = vehicle.Accident;
                vec.Km = vehicle.Km;
                vec.Price = vehicle.Price;
            }
>>>>>>> 33e520dbbcce61cb230cf00b90ff116e5de8e5fc
            return Ok();
        }

        // DELETE api/<VehiclesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
<<<<<<< HEAD
            _vehicleService.DeleteVehicle(id);
=======
            var vec = _context.VehiclesList.Find(x => x.Id == id);
            if (vec != null)
            {
                _context.VehiclesList.Remove(vec);
            }
>>>>>>> 33e520dbbcce61cb230cf00b90ff116e5de8e5fc
            return Ok();
        }
    }
}
