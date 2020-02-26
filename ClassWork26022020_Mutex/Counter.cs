using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassWork26022020_Mutex
{
    class Counter
    {
        int count;
        Mutex m = new Mutex(false, "SM");
        public int Count
        {
            get { return count; }

        }

        public void UpdateFields()
        {
            for(int i = 0; i < 1000000; ++i)
            {
                m.WaitOne();
                ++count;
                m.ReleaseMutex();
            }
        }
    }
}
