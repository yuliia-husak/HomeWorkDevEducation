using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest_EmtityFram_WPF
{
    static class OtherMethods
    {
        public static Vendors GetAuthorByIdFind(string id)
        {
            ShopTestEntities context = new ShopTestEntities();
           
            return context.Vendors.Find(id);
        }
    }
}
