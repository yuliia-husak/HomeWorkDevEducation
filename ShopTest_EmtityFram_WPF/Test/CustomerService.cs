using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest_EmtityFram_WPF.Test
{
    public class CustomerService:ICustomerService
    {
        public CustomerService(ICustomerRepository customerRepository, IValidator<Customer> customerValidator)
        {
            CustomerValidator = customerValidator;
            CustomerRepository = customerRepository;
        }

        public ICustomerRepository CustomerRepository { get; private set; }
        public IValidator<Customer> CustomerValidator { get; private set; }

        public void Register(Customer customer)
        {
            var isValid = CustomerValidator.Validate(customer);
            if (isValid)
            {
                CustomerRepository.Save(customer);
            }
            else
            {
                throw new ArgumentException("Invalid customer", "customer");
            }
        }


        public void Register(int id, string firstName, string lastName)
        {
            var customer = new Customer { Id = id, FirstName = firstName, LastName = lastName };

            var isValid = CustomerValidator.Validate(customer);
            if (isValid)
            {
                CustomerRepository.Save(customer);
            }
            else
            {
                throw new ArgumentException("Invalid customer", "customer");
            }
        }

        public void RegisterOut(int id, string firstName, string lastName)
        {
            var customer = new Customer { Id = id, FirstName = firstName, LastName = lastName };

            Customer outCustomer = null;
            var isValid = CustomerValidator.ValidateOut(customer, out outCustomer);
            if (isValid)
            {
                CustomerRepository.Save(customer);
            }
            else
            {
                throw new ArgumentException("Invalid customer", "customer");
            }
        }

        public void RegisterRef(int id, string firstName, string lastName)
        {
            var customer = new Customer { Id = id, FirstName = firstName, LastName = lastName };

            Customer refCustomer = null;
            var isValid = CustomerValidator.ValidateRef(customer, ref refCustomer);
            if (isValid)
            {
                CustomerRepository.Save(customer);
            }
            else
            {
                throw new ArgumentException("Invalid customer", "customer");
            }
        }

        public void DeleteCustomers(params int[] customerIds)
        {
            List<Customer> customers = new List<Customer>();
            foreach (var customerId in customerIds)
            {
                customers.Add(CustomerRepository.FindById(customerId));
            }
            CustomerRepository.DeleteCustomers(customers);
        }

        public void Delete(Customer customer)
        {
            CustomerRepository.Delete(customer);
        }

        public Customer GetListOfProducts(string firstName)
        {
            // mult cod
            return CustomerRepository.GetCustomerByFirstName(firstName);
        }


    }
}
