using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jjjjjjjj
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write(fun());

            //try
            //{
            //    int s = Convert.ToInt32("R");
            //    int x = 4;
            //    int y = x / 0;
            //    Console.WriteLine("Succes");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("DivideByZeroException");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("FormatException");
            //}
            //finally
            //{
            //    Console.WriteLine("Finish");
            //}
            //Console.WriteLine("Exit");

            //throw new Exception();
            //try
            //{
            //    Console.WriteLine("Hello");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error");
            //}
            //finally
            //{
            //    Console.WriteLine("Finish");
            //}



            Console.ReadKey();
        }

        static int fun()
        {
            int x = 0;
            try
            {
                x = 1;
                return x;
            }
            catch
            {
                x = 2;
            }
            finally
            {
                x = 3;
            }
            x = 4;
            return x;
        }
    }
}
