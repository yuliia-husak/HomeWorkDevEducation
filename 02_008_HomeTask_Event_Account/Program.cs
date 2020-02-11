using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_008_HomeTask_Event_Account
{
    class Program
    {

        static void Main(string[] args)
        {
            Account acc = new Account(100);
            acc.Notify += DisplayMessage;
            //acc.Notify += DisplayRedMessage;
            acc.Put(20);
            //Console.WriteLine($"Сумма на счете: {acc.Sum}");
            acc.Take(70);
            //Console.WriteLine($"Сумма на счете: {acc.Sum}");
            acc.Take(180);
            //Console.WriteLine($"Сумма на счете: {acc.Sum}");

            Console.Read();

        }

        private static void DisplayRedMessage(object sender, AccountEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.ResetColor();
        }

        private static void DisplayMessage(object sender, AccountEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
   