using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassWork26022020_Multithreaded_Processing
{
    class Program
    {
        static Thread[] threads;

        static int n;
        
        static void Run(object some_data)
        {
            int m = (int)some_data;
            threads = new Thread[m];

        }

       
        static void Main(string[] args)
        {
            VectorArray vectorArray = new VectorArray(10);
            VectorArray vectorArray1 = new VectorArray(100);
            VectorArray vectorArray2 = new VectorArray(1000);
            VectorArray vectorArray3 = new VectorArray(100000);

            
            vectorArray1.MultiVector();
            vectorArray1.Show();
            Thread thr = new Thread(Run);
            
            

            Console.ReadKey();
        }
    }
}
