using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_010_HomeTask_List_Exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random rnd = new Random();

            #region DublicateDelet
            Simle<int> vs = new Simle<int>();
            for(int i = 0; i < 20; i++)
            {
                int temp = rnd.Next(1, 100);
                vs.Add(temp);  
            }
            
            foreach(var item in vs)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // проверяем наличие элемента
            bool isPresent = vs.Contains(20);
            Console.WriteLine(isPresent == true ? "20 присутствует"
                : "20 отсутствует");
            vs.Remove(10);
            #endregion

            #region List
            List<int> vs1 = new List<int>();
            for (int i = 0; i < 55; i++)
            {
                int temp = rnd.Next(1, 1000);
                vs1.Add(temp);
            }




            #endregion


            Console.ReadLine();
        }

        public static int MethodTwo(List<T> ts)
        {
            int x = 0;

            foreach (var item in List)
            {

            }


            return x;
        }
    }
}
