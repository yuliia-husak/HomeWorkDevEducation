using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest_EmtityFram_WPF.Test
{
    class DataBase
    {
        private List<string> db;
        public DataBase()
        {
            db = new List<string>();
        }
        public bool HasInventory(string productName)
        {
            return db.Contains(productName);
        }
        public void Remove(string productName)
        {
            db.Remove(productName);
        }
    }
}
