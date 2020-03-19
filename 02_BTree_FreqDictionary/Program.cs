using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BTree_FreqDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            FreqDictionary dictionary = new FreqDictionary();
            dictionary.Start();

            Console.ReadKey();
        }
    }
}
