using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest_EmtityFram_WPF.Test
{
    public interface ICustomerService
    {
        void Register(Customer customer);
        void Register(int id, string firstName, string lastName);
        void DeleteCustomers(params int[] personIds);
        void Delete(Customer customer);
        Customer GetListOfProducts(string firstName);
    }
}
