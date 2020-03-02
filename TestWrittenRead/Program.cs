using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWrittenRead
{
    public class Class
    {
        public static void Method(int a, ref int b,out int d)
        {
            a = 15;
            b = 22;
            d = 1001;
            Console.WriteLine("a = {0}, b =  {1}, d = {2} in Method ", a, b, d);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {

            try
            {
                StreamWriter f = new StreamWriter(@"d:\C#\output1.txt");

                string a22 = "255555555555555555555555555555555555555vvv";
                int b22 = 65;
                int c = 135;
                f.WriteLine(a22 + b22 + c);
                f.WriteLine(a22);
                f.WriteLine(b22);
                f.WriteLine(c);
                f.Close();

                StreamReader streamReader = new StreamReader(@"d:\C#\output.txt");
                string s = streamReader.ReadLine();
                Console.WriteLine(s);
                streamReader.Close();

                throw new FileNotFoundException();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Exception in NameFile");
            }

            Console.WriteLine("Enter x: ");
            string buf = Console.ReadLine();
            double x = double.Parse(buf);
            Console.WriteLine("Sin = {0} ", Math.Sin(x));

            Console.WriteLine("Enter y: ");
            buf = Console.ReadLine();
            double y = double.Parse(buf);
            Console.WriteLine("Max = {0}", Math.Max(x, y));

            float o, t;
            o = 3.2569F;
            t = 3.2568F;
            if (o == t) Console.WriteLine("o==t");
            else Console.WriteLine("o!=t");

            if (Math.Abs(o - t) < 1e-6) Console.WriteLine("Math.Abs good");
            else Console.WriteLine("Math != o < t");

            double yy = 1e-6;
            Console.WriteLine("1e-6 = " + yy);
            Console.WriteLine("o-t = " + (o - t));

            Console.WriteLine(new string('-', 50));
            int a = 1;
            int b = 2;
            int d;
            Console.WriteLine("a = {0}, b =  {1} in Main before Method ", a, b);
           
            Class.Method(a, ref b, out d);
            Console.WriteLine("a = {0}, b =  {1}, d = {2} in Main ", a, b, d);   

            Console.ReadKey();
        }
    }
}
