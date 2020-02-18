using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplLINQ_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, -2, 3, 0, -4, 5 };

            var posNum = from vs in nums
                         where vs % 2 == 0
                         select vs;

            //var posNum2 = from vs in nums
            //             where vs > 0
            //             select vs;

            IEnumerable<int> vs1 = from n in nums
                                   where n > 0
                                   select n;

            Console.Write("Четные значения из массива nums: ");
            foreach(var item in posNum)
            {
                Console.Write(item + " ");
            }

            Console.Write("Положительные значения из массива nums: ");
            foreach (var item in /*posNum2*/vs1)
            {
                Console.Write(item + " ");
            }



            Console.ReadKey();
        }
    }
}
