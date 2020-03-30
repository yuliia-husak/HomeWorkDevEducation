using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest_EmtityFram_WPF.Test
{
    public class Warehouse : IWarehouse
    {
        private DataBase db;
        public Warehouse()
        {
            db = new DataBase();
        }
        public virtual bool HasInventory(string productName)
        {
            return db.HasInventory(productName);
        }

        public virtual void Remove(string productName)
        {
            db.Remove(productName);
        }
    }
}
