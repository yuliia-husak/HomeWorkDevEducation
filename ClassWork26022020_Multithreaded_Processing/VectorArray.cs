using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork26022020_Multithreaded_Processing
{
    class VectorArray
    {
        private int[] VecArray;

        Random rnd = new Random();
        
        public VectorArray(int n)
        {            
            VecArray = new int[n];

        }

        public void MultiVector()
        {
            for (int i = 0; i < VecArray.Length; i++)
                VecArray[i] = VecArray[i]*3;
        }

        public void Show()
        {
            for(int i = 0; i < VecArray.Length; i++)
            {
                Console.Write(VecArray[i] + " ");
            }
        }

    }
}
