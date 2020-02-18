using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace AsyncInput_Example
{
    class Demo
    {
        public void UserInput() //диалог с пользователем
        {
            string s;
            do
            {
                Console.WriteLine("Введите строку. Enter для завершения");
                s = Console.ReadLine();
            } while (s.Length != 0);            
        }

        public void OnComletedRead(IAsyncResult ar)//метод должен получать один параметр стандартного типа IAsyncResult
        {
            int bytes = f.EndRead(ar);
            Console.WriteLine("Считано " + bytes);
        }

        public void AsyncRead()
        {
            f = new FileStream(@"C:\Users\user\Source\Repos\HomeWorkDevEducation4\AsyncInput_Example\verybigfile.txt",
                FileMode.Open, FileAccess.Read, FileShare.Read, buf.Length, true);//true-метод открывается в ассинхронном режиме
            callback = new AsyncCallback(OnComletedRead);//создается стандартный делегат AsyncCallbac, который инициал. методом OnCompletedRead
            f.BeginRead(buf, 0, buf.Length, callback, null);//начинается асинхронный ввод
        }

        FileStream f;
        byte[] buf = new byte[66666666];
        AsyncCallback callback;
    }
}
