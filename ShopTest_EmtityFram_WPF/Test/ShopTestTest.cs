using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Rhino.Mocks;
using ShopTest_EmtityFram_WPF.Test;

namespace ShopTest_EmtityFram_WPF
{
    [TestFixture]
    class ShopTestTest
    {
        [Test]
        public static void FirstTest()
        {
            Order order = new Order("Doun");
            var stubUserRepository = MockRepository.GenerateStub<Warehouse>();

            stubUserRepository.Stub(x => x.HasInventory("Doun")).Return(true);
            stubUserRepository.Stub(x => x.Remove("Doun"));

            order.Fill(stubUserRepository);
            Assert.IsTrue(order.IsFilled);
        }
    }
}
