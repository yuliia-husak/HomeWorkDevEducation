using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamReader_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader f = new StreamReader("outputtext.txt");
                string s = f.ReadToEnd();
                Console.WriteLine(s);

                f.Close();
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Проверьте правильность имени файла!");
                Console.Read();
                return;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return;
            }

            Console.Read();
        }
    }
}
