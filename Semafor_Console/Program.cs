using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Semaphore_Console
{
    class Program
    {
        //создаем закрытое статическое поле типа Семафор с именем пул
        private static Semaphore pool;

        private static void Work(object number)
        {
            //требуем занять один из свободных слоев семафора
            pool.WaitOne();

            //как только занял выводим на консоль сообщение
            Console.WriteLine("Поток {0} занял слот семафора", number);
            Thread.Sleep(1000);
            Console.WriteLine("Поток {0} -------------> освободил слот", number);

            pool.Release();
        }
        static void Main(string[] args)
        {
            //создаем экземпляр класса семафор 
            //1 аргумент(2) какое кол-во слотов будет занимать семафор
            //2 аргумент : общее кол-во слотов семафора
            //3 аргумент : уникальное имя семафора
            pool = new Semaphore(5, 10, "Semaphore_Console");

            for(int i = 0;i <= 20; i++)
            {
                Thread thread = new Thread(new ParameterizedThreadStart(Work));
                thread.Start(i);
            }


            Thread.Sleep(2000);

            //освободить семафор
            pool.Release(2);


            Console.ReadKey();
        }
    }
}
