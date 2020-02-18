using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriter_ThreadSymbol
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamWriter f = new StreamWriter("outputtext.txt");
                f.WriteLine("Вывод в текстовый файл: 11111111111111111111111111111");
                
                double a = 12.234;
                int b = 29;
                //f.WriteLine("a = {0.6:C} b = {1.2:X}", a, b);
                f.WriteLine("a = {0,6:C} b = {1,2:X}", a, b);
                f.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return;
            }

            Console.ReadKey();
        }
    }
}
