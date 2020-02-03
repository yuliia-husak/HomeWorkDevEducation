using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    delegate void Symbol(char c);

    class MyClass
    {
        public char myField;

        public void MyMethod(char c)
        {
            myField = c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var array = new MyClass[3] { new MyClass(), new MyClass(), new MyClass() };
            Symbol del = null;
            foreach (var item in array)
            {
                del += item.MyMethod;
            }
            char c = 't';
            del(c);
            foreach (var item in array)
            {
                Console.WriteLine(item.myField);
            }
            Console.ReadKey();
        }
    }
}
