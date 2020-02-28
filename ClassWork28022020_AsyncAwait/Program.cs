using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork28022020_AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            string poem = "Two roads, diverged. in a yellow wood,";
            //"And sorry I could not travel both",
            //"And be one traveler, long I stood",
            //"And look down one as far as I coul",
            //"To where it bent in the undergrowth;",
            // "en took the other, as just as fair,",
            //"And having perhaps the better claim,",
            //"Because it was grassy and wanted wear;",
            // "Though as for that the passing there",
            //  "Had worn them really about the same,"};

            var myDelegate = new Func<string, int>(Method2);
            IAsyncResult resultObj = myDelegate.BeginInvoke(poem, null, null);
            int count = myDelegate.EndInvoke(resultObj);
            Console.WriteLine(count);


            myDelegate = new Func<string, int>(Method1);
            resultObj = myDelegate.BeginInvoke(poem, null, null);
            int count2 = myDelegate.EndInvoke(resultObj);
            Console.WriteLine(count2);

            Console.ReadKey();
        }

        public static int Method1(string str)
        {
            string[] s = str.Split();

            Console.WriteLine("Count = " + s.Length);
            return s.Length;
        }

        public static int Method2(string str)
        {
            int count2 = 0;
            for (int i = 0; i < str.Length; i++)
            {

                if ((str[i] == ',') || str[i] == '.') count2++;
            }

            Console.WriteLine("Count2 = " + count2);
            return count2;
        }
    }
}
