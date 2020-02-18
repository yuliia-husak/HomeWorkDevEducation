using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriter_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //*********Вывод в текстовый файл*******************
            //Объявляем фаайловую переменную и связываем ее с файлом на диске
            //Создаем файл

            StreamWriter w = new StreamWriter("output.txt");

            int i = 3;
            double y = 4.12;
            decimal d = 600m;
            string s = "Вася";

            w.WriteLine("i = " + i);
            w.WriteLine("y = {0} \nd = {1}", y, d);
            w.WriteLine("s = " + s);

            //закрыть файл
            w.Close();


            //Ввод из текстового файла
            StreamReader r = new StreamReader("C:\\Users\\user\\Source\\Repos\\HomeWorkDevEducation4\\StreamWriter_Example\\input.txt");
            string sR = r.ReadLine();
            Console.WriteLine("s = " + sR);

            char cR = (char)r.Read();
            r.ReadLine();
            Console.WriteLine("c = " + cR);

            string buf;
            buf = r.ReadLine();
            int iR = Convert.ToInt32(buf);
            Console.WriteLine(iR);

            buf = r.ReadLine();
            double xR = Convert.ToDouble(buf);
            Console.WriteLine(xR);

            buf = r.ReadLine();
            double yR = double.Parse(buf);
            Console.WriteLine(yR);

            buf = r.ReadLine();
            decimal zR = decimal.Parse(buf);
            Console.WriteLine(zR);
            r.Close();




            Console.ReadKey();
        }
    }
    
}
