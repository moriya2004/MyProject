using Microsoft.AspNetCore.Mvc;
using Yad2.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yad2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        
        private readonly DataContext _context;
        static int cnt = 0;
        public VehiclesController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<VehiclesController>
        [HttpGet]
        public ActionResult<IEnumerable<Vehicle>> Get()
        {
            return _context.VehiclesList;
        }

        // GET api/<VehiclesController>/5
        [HttpGet("{id}")]
        public ActionResult<Vehicle> Get(int id)
        {
            var vehicle = _context.VehiclesList.Find(x => x.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }
            return vehicle;
        }

        // POST api/<VehiclesController>
        [HttpPost]
        public void Post([FromBody] Vehicle vehicle)
        {
            cnt++;
            _context.VehiclesList.Add(new Vehicle { Id=cnt,Type=vehicle.Type,Company=vehicle.Company,YearOfProduction=vehicle.YearOfProduction,Accident=vehicle.Accident,Km=vehicle.Km,Price=vehicle.Price});
            
        }

        // PUT api/<VehiclesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Vehicle vehicle)
        {
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
            return Ok();
        }

        // DELETE api/<VehiclesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var vec = _context.VehiclesList.Find(x => x.Id == id);
            if (vec != null)
            {
                _context.VehiclesList.Remove(vec);
            }
            return Ok();
        }
    }
}
