using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStream_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //FileMode - режим открытия
                //FileAccess - режим чтения

                FileStream f = new FileStream("test.txt",
                    FileMode.Create, FileAccess.ReadWrite);

                //запис в нaчало файла
                f.WriteByte(100);

                byte[] x = new byte[10];
                for (byte i = 0; i < 10; ++i)
                {
                    x[i] = (byte)(10 - i);
                    f.WriteByte(i);//записываем 10 чисел от 0 до 9
                }

                f.Write(x, 0, 5);//записываем 5 элементов массива

                byte[] y = new byte[20];

                f.Seek(0, SeekOrigin.Begin);//текущий указатель - на начало
                f.Read(y, 0, 20);           //чтение из файла в массив

                foreach (byte elem in y) Console.Write(" " + elem);
                Console.WriteLine();

                f.Seek(5, SeekOrigin.Begin);//текущий указатель - на 5-й элемент
                int a = f.ReadByte();//чтение 5-го элемента
                Console.WriteLine(a);
                a = f.ReadByte();//чтение 6-го элемента
                Console.WriteLine(a);

                Console.WriteLine("Текущая позиция в потоке" + f.Position);
                f.Close();
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Проверьте правильность имени файла!");
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
