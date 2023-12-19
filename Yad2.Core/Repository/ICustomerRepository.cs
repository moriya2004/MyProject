using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Core.Entities;

namespace Yad2.Core.Repository
{
    public interface ICustomerRepository
    {
        
        List<Customer> GetCustomers();
        Customer AddCustomer(Customer c);
        Customer GetCustomerById(int id);
        void UpdateCustomer(Customer customer1, Customer customer2);
        void DeleteCustomer(Customer c);

    }
}
