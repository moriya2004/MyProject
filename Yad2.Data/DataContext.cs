using Yad2.Core.Entities;


namespace Yad2
{
    public class DataContext
    {
        public List<Customer> CustomersList { get; set; }
        public List<Mediator> MediatorsList { get; set; }
        public List<Vehicle> VehiclesList { get; set; }
        public DataContext()
        {
            CustomersList = new List<Customer>();
            MediatorsList = new List<Mediator>();
            VehiclesList = new List<Vehicle>();

        }
    }
}
