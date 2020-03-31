using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest_EmtityFram_WPF.Test
{
    public interface ICustomerRepository
    {
        Customer FindById(int person);
        void Save(Customer customer);
        void DeleteCustomers(List<Customer> customers);
        void Delete(Customer customer);
        Customer GetCustomerByFirstName(string firstName);
    }
}
