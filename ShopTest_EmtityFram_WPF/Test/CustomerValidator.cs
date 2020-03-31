using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest_EmtityFram_WPF.Test
{
    public class CustomerValidator : IValidator<Customer>
    {
        public bool Validate(Customer model)
        {
            return model != null;
        }

        public bool ValidateOut(Customer model, out Customer outModel)
        {
            throw new System.NotImplementedException();
        }

        public bool ValidateRef(Customer model, ref Customer outModel)
        {
            throw new System.NotImplementedException();
        }
    }
}
