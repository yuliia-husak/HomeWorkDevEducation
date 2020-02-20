using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CarRaling
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Car";

            // Задается размер окна.
            Console.SetWindowSize(93, 50);

            // Задается видимость курсора.
            Console.CursorVisible = true;

            Game game = new Game();            
            
            game.Run();

            // Delay.
            Console.Read();
        }
    }
}
