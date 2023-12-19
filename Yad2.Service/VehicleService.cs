using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Core.Entities;
using Yad2.Core.Repository;

namespace Yad2.Service
{
    public class VehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        public List<Vehicle> GetAllVehicles()
        {
            //business logic

            return _vehicleRepository.GetVehicles();
        }
        public Vehicle GetVehicleById(int id)
        {
            //business logic

            return _vehicleRepository.GetVehicleById(id);
        }

        public Vehicle AddVehicle(Vehicle v)
        {
            //business logic

            return _vehicleRepository.AddVehicle(v);
        }
        public void UpdateVehicle(int id, Vehicle vehicle2)
        {
            //business logic
            var vehicle1 = _vehicleRepository.GetVehicles().Find(v => v.Id == id);
            vehicle2.Id = id;
            _vehicleRepository.UpdateVehicle(vehicle1, vehicle2);
        }
        public void DeleteVehicle(int id)
        {
            //business logic
            var v = _vehicleRepository.GetVehicles().Find(c => c.Id == id);
            _vehicleRepository.DeleteVehicle(v);
        }

    }
}
