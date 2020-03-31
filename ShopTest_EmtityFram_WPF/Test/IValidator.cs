using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest_EmtityFram_WPF.Test
{
    public interface IValidator<TModel>
    {
        bool Validate(TModel model);
        bool ValidateOut(TModel model, out TModel outModel);
        bool ValidateRef(Customer model, ref Customer outModel);
    }
}
