using _02_002_Classes_Consstructors.MultiHouse;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace _02_002_Classes_Consstructors_Tests
{

    [TestClass]
    public class UnitTest1
    {

        Human human = new Human();
        Human human1 = new Human();
        Apartment apartment = new Apartment(1, 2);
        
        PaymentsCommunal payments = new PaymentsCommunal();


        [TestMethod]
        public void ChecGas_1and2_returned12_70()
        {
            apartment.Add(human);
            apartment.Add(human1);

            double extected = 12.70;

            double actual = payments.PayGas(apartment);

            Assert.AreEqual(extected, actual);

        }

        [TestMethod]
        public void ChecRent_1and2_returned2_50()
        {
            apartment.Add(human);
            apartment.Add(human1);

            double extected = 5.00;

            double actual = payments.PayRent(apartment);

            Assert.AreEqual(extected, actual);
        }

        [TestMethod]
        public void ChecWouter_1and2_returned25_00()
        {
            apartment.Add(human);
            apartment.Add(human1);

            double extected = 25.00;

            double actual = payments.PayWouter(apartment);

            Assert.AreEqual(extected, actual);
        }

        [TestMethod]
        public void ChecElectric_1and2_returned10_00()
        {
            apartment.Add(human);
            apartment.Add(human1);

            double extected = 10.00;

            double actual = payments.PayElectricity(apartment);

            Assert.AreEqual(extected, actual);
        }
    }
}
