using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamReader_LineByLine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader f = new StreamReader("outputtext.txt");
                string s;
                long i = 0;

                while ((s = f.ReadLine()) != null)
                    Console.WriteLine("{0}:{1}", ++i, s);
                f.Close();
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Проверьте правильность имени файла!");
                return;
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
