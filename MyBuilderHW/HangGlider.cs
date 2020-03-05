using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuilderHW
{
    class HangGlider : Aircraf
    {
        ArrayList partHang = new ArrayList();       
        
        public override void Add(string part)
        {
            partHang.Add(part);
        }

        public override void Show()
        {
            foreach (string part in partHang)
                Console.WriteLine(part);
        }

        
    }
}
