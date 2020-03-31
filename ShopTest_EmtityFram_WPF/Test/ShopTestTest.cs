using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Rhino.Mocks;
using ShopTest_EmtityFram_WPF.Test;
using Moq;


namespace ShopTest_EmtityFram_WPF
{
    [TestFixture]
    public class ShopTestTest
    {
        [Test]
        public static void FirstTest()
        {
            Order order = new Order("Doun");
            var stubUserRepository = Rhino.Mocks.MockRepository.GenerateStub<Warehouse>();

            stubUserRepository.Stub(x => x.HasInventory("Doun")).Return(true);
            stubUserRepository.Stub(x => x.Remove("Doun"));

            order.Fill(stubUserRepository);
            Assert.IsTrue(order.IsFilled);
        }


        #region Initial
        [Test]
            public void RegisterNewPerson_SaveThePerson_WhenThePersonIsValid()
            {
                //Arrange
                var mockCustomerRepository = new Mock<ICustomerRepository>();
                var customerValidator = new Mock<IValidator<Customer>>();
                customerValidator.Setup(x => x.Validate(It.IsAny<Customer>())).Returns(true);
                var customerService = new CustomerService(mockCustomerRepository.Object, customerValidator.Object);

                var customer = new Customer
                {
                    Id = 123,
                    FirstName = "Adrian",
                    LastName = "Cadar"
                };

                //Act
                customerService.Register(customer);

                //Assert
                mockCustomerRepository.Verify(m => m.Save(customer), Times.Once);
            }

            [Test]
            public void RegisterNewPerson_ThrowsException_WhenThePersonIsNotValid()
            {
                //Arrange
                var mockCustomerRepository = new Mock<ICustomerRepository>();
                var customerValidator = new Mock<IValidator<Customer>>();
                var customerService = new CustomerService(mockCustomerRepository.Object, customerValidator.Object);
                try
                {
                    customerService.Register(null);
                    Assert.Fail("ArgumentException excepted");
                }
                catch (Exception e)
                {
                    Assert.IsInstanceOf<ArgumentException>(e);
                }
            }
            #endregion

            #region Argument Constraints
            [Test]
            public void ParamsRegisterNewPerson_SaveThePerson_WhenThePersonIsValid()
            {
                //Arrange
                var mockCustomerRepository = new Mock<ICustomerRepository>();
                var customerValidator = new Mock<IValidator<Customer>>();
                customerValidator.Setup(x => x.Validate(It.IsAny<Customer>())).Returns(true);
                var personService = new CustomerService(mockCustomerRepository.Object, customerValidator.Object);


                int id = 123;
                string firstName = "Adrian";
                string lastName = "Cadar";

                //Act
                personService.Register(id, firstName, lastName);

                //Assert
                mockCustomerRepository.Verify(x => x.Save(It.Is<Customer>(p => p.Id == id && p.FirstName == firstName && p.LastName == lastName)));

            }

            [Test]
            public void DeleteCustomers_DeletesAllCustomersPassedIn()
            {
                //Arrange
                const int customerId1 = 123;
                const int customerId2 = 343;
                const int customerId3 = 654;

                Customer customer1 = new Customer { Id = customerId1, FirstName = "Adrian", LastName = "Cadar" };
                Customer customer2 = new Customer { Id = customerId2, FirstName = "Creaza", LastName = "Persoane" };
                Customer customer3 = new Customer { Id = customerId3, FirstName = "Catmai", LastName = "Fakes" };

                var mockCustomerRepository = new Mock<ICustomerRepository>();
                mockCustomerRepository.Setup(x => x.FindById(customerId1)).Returns(customer1);
                mockCustomerRepository.Setup(x => x.FindById(customerId2)).Returns(customer2);
                mockCustomerRepository.Setup(x => x.FindById(customerId3)).Returns(customer3);

                var customerService = new CustomerService(mockCustomerRepository.Object, null);

                // Act
                customerService.DeleteCustomers(customerId1, customerId2, customerId3);

                //Assert
                mockCustomerRepository.Verify(m => m.DeleteCustomers(It.Is<List<Customer>>(l => l.Count == 3)));
                mockCustomerRepository.Verify(m => m.DeleteCustomers(It.Is<List<Customer>>(l => l.Contains(customer1))));
            }
            /**/
            [Test]
            public void GetCustomerByFirstName_GetTheCustomerFromRepository()
            {
                // Arrange
                var mockCustomerRepository = new Mock<ICustomerRepository>();
                var customerService = new CustomerService(mockCustomerRepository.Object, null);

                // Act
                customerService.GetListOfProducts("Jones");

                // Assert
                mockCustomerRepository.Verify(x => x.GetCustomerByFirstName(It.Is<string>(s => s.Contains("one"))));
                mockCustomerRepository.Verify(x => x.GetCustomerByFirstName(It.Is<string>(s => s.EndsWith("nes"))));
                mockCustomerRepository.Verify(x => x.GetCustomerByFirstName(It.Is<string>(s => s.StartsWith("Jon"))));
                //mockCustomerRepository.Verify(x => x.GetCustomerByFirstName(It.Is<string>(s => Like(s,"Jone.*"))));
            }

            #endregion

            //#region Out/Ref Parameters
            //[Test]
            //public void ParamsRegisterNewCustomer_SaveTheCustomer_WhenTheCustomerIsValid_WithOutRef()
            //{
            //    //Arrange
            //    var mockCustomerRepository = new Mock<ICustomerRepository>();
            //    var customerValidator = new Mock<IValidator<Customer>>();
            //    var customerService = new CustomerService(mockCustomerRepository.Object, customerValidator.Object);

            //    int id =888;
            //    string firstName ="Adrian";
            //    string lastName ="Cadar";

            //    Customer customer = new Customer { Id = id, FirstName = firstName, LastName = lastName };
            //    // Out
            //    customerValidator.Setup(x => x.ValidateOut(It.IsAny<Customer>(), out customer)).Returns(true);

            //    // Only matches if the ref argument to the invocation is the same instance
            //    customerValidator.Setup(x => x.ValidateRef(It.IsAny<Customer>(), ref customer)).Returns(true); // <- must see

            //    //Act
            //    customerService.RegisterOut(id, firstName, lastName);
            //    customerService.RegisterRef(id, firstName, lastName);

            //    //Assert
            //    mockCustomerRepository.Verify(x => x.Save(It.Is<Customer>(p => p.Id == customer.Id && p.FirstName == customer.FirstName && p.LastName == customer.LastName)));
            //}
            //#endregion
        }
    }
