using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork21022020_UserCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            NameCollection nameCollection = new NameCollection();
            foreach(string s in nameCollection)
            {
                Console.Write(" " + s);
            }

            Console.ReadLine();
        }
    }
}
