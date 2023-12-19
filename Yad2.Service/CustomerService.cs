using Yad2.Core.Entities;
using Yad2.Core.Repository;


namespace Yad2.Service
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public List<Customer> GetAllCustomers()
        {
            //business logic
            
            return _customerRepository.GetCustomers();
        }
        public Customer GetCustomerById(int id)
        {
            //business logic

            return _customerRepository.GetCustomerById(id);
        }

        public Customer AddCustomer(Customer c)
        {
            //business logic

            return _customerRepository.AddCustomer(c);
        }
        public void UpdateCustomer(int id,Customer c)
        {
            //business logic
            var cus = _customerRepository.GetCustomers().Find(c => c.Id == id);
            c.Id = id;
            _customerRepository.UpdateCustomer(cus,c);
        }
        public void DeleteCustomer(int id)
        {
            //business logic
            var cus = _customerRepository.GetCustomers().Find(c => c.Id == id);
            _customerRepository.DeleteCustomer(cus);
        }
    }
}