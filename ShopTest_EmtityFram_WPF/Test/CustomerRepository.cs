using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest_EmtityFram_WPF.Test
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomers(List<Customer> customers)
        {
            throw new NotImplementedException();
        }

        public Customer FindById(int person)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerByFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
