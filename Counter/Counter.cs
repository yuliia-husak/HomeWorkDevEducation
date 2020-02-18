using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class CountDown
    {
        int val; 
        public CountDown(int n) { val = n; }
        public void Reset(int n) { val = n; }
        public int Count()
        { 
            if 
                (val > 0) return val--; 
            else 
                return 0; 
        }
    }
}
namespace Counter2
{
    /* Этот класс CountDown относится к пространству имен Counter2 и поэтому не вступает в конфликт с аналогичным классом из пространства имен Counter. */
    class CountDown
    {
        public void Count()
        {
            Console.WriteLine("Это метод Count() из "
                + "пространства имен Counter2.");
        }
    }
}