using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork05022020_Generics
{
    class MyDictionary
    {
        public int key { get; set; } = 0;
        public string value { get; set; }


        public MyDictionary(string y)
        {
            this.key = key++;
            this.value = y;

        }
    }
}
