using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_001_HomeWork_Collections_Iterator
{
    abstract class Iterator
    {
        public abstract object First(); 
        public abstract object Next(); 
        public abstract bool IsDone(); 
        public abstract object CurrentItem();
    }
}
