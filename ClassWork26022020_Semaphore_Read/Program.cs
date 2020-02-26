using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork26022020_Semaphore_Read
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 6; i++)
            {
                Reader reader = new Reader(i);
            }


            Console.ReadKey();
        }
    }
}
