using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterDecimal
{
    class ExeptionCount:Exception
    {
        public object Count { get; set; }

        public ExeptionCount(int count)
        {
            Count = count;
        }
    }
}
