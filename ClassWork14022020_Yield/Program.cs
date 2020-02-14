using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork14022020_Yield
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> collection = new List<int>();
            collection.Add(0);
            collection.Add(1);
            collection.Add(2);
            collection.Add(3);
            collection.Add(4);

            foreach (int element in Method(collection))
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }

        static IEnumerable Method(List<int> vs)
        {

            foreach (int element in vs)
            {
                if (element > 2)
                {
                    yield return element;
                }
            }           
        }
    }
}
