using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace ShopTest_EmtityFram_WPF.Test
{
    public class FakeCustomerRepository : Mock<ICustomerRepository>
    {
        public FakeCustomerRepository()
        {
            base.Setup(x => x.FindById(It.IsAny<int>())).Returns(new Customer());

        }
    }
}
