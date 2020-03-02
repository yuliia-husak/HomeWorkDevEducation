using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Counter counter = new Counter();
                counter.Password();
               
                Console.WriteLine(counter.GetCount);

                Counter counter1 = new Counter(10, 15, 20);
                counter1.Password();
                Console.WriteLine(counter1.GetCount);

                counter.Rase();
                counter1.Rase();

                Console.WriteLine(counter.GetCount);
                counter.Password();
                Console.WriteLine(counter1.GetCount);
                counter1.Password();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ParamName);
            }

            Console.ReadLine();
        }
    }
}
