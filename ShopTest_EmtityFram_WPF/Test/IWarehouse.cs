using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest_EmtityFram_WPF.Test
{
    public interface IWarehouse
    {
        bool HasInventory(string productName);
        void Remove(string productName);
    }
}
