using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_002_Classes_Consstructors._03_Task_MyString
{
    class MyString
    {
        MyString myString;
        private readonly char n;
        public char N { get; set; }
        public MyString(char n)
        {
            this.n = n;
            //myString = new String(n);
        }

    }
}
