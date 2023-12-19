using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Core.Entities;

namespace Yad2.Core.Repository
{
    public interface IVehicleRepository
    {
        List<Vehicle> GetVehicles();
        Vehicle AddVehicle(Vehicle c);
        Vehicle GetVehicleById(int id);
        void UpdateVehicle(Vehicle vehicle1, Vehicle vehicle2);
        void DeleteVehicle(Vehicle c);
    }
}
