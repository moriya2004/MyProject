using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Core.Entities;
using Yad2.Core.Repository;

namespace Yad2.Data
{
   
    public class VehicleRepository : IVehicleRepository
    {
        private readonly DataContext _context;

        public VehicleRepository(DataContext context)
        {
            _context = context;
        }
        public List<Vehicle> GetVehicles()
        {
            return _context.VehiclesList;
        }
        public Vehicle GetVehicleById(int id)
        {
            return _context.VehiclesList.Find(c => c.Id == id);
        }

        public Vehicle AddVehicle(Vehicle vehicle)
        {
            vehicle.Id = _context.VehiclesList.Count() + 1;
            _context.VehiclesList.Add(new Vehicle { Id = vehicle.Id, Type = vehicle.Type, Company = vehicle.Company, YearOfProduction = vehicle.YearOfProduction, Accident = vehicle.Accident, Km = vehicle.Km, Price = vehicle.Price });
            return vehicle;
        }
        public void UpdateVehicle(Vehicle vehicle1, Vehicle vehicle2)
        {
            _context.VehiclesList.Remove(vehicle1);
            _context.VehiclesList.Add(vehicle2);
        }
        public void DeleteVehicle(Vehicle vehicle)
        {
            _context.VehiclesList.Remove(vehicle);
        }
    }
}
