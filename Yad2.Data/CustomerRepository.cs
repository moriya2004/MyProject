using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Core.Entities;
using Yad2.Core.Repository;

namespace Yad2.Data
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly DataContext _context;
        
        public CustomerRepository(DataContext context)
        {
            _context = context;
        }
        public List<Customer> GetCustomers()
        {
            return _context.CustomersList;
        }
        public Customer GetCustomerById(int id)
        {
            return _context.CustomersList.Find(c => c.Id == id);
        }

        public Customer AddCustomer(Customer customer)
        {
            customer.Id = _context.CustomersList.Count() + 1;
             _context.CustomersList.Add(new Customer { Id = customer.Id, Name = customer.Name, Phone = customer.Phone, Email = customer.Email }) ;
            return customer;
        }
        public void UpdateCustomer(Customer cus, Customer c)
        {
            _context.CustomersList.Remove(cus);
            _context.CustomersList.Add(c);
        }
        public void DeleteCustomer(Customer cus)
        {
            _context.CustomersList.Remove(cus);
        }

    }
}
