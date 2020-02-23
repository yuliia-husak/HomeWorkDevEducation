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
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Car";

            // Задается размер окна.
            Console.SetWindowSize(93, 50);

            // Задается видимость курсора.
            Console.CursorVisible = true;

            Game game = new Game();

            game.AddCar(new Car(10, 35, "1", "BMV"));
            game.AddCar(new Car(40, 35, "2", "Ferrary"));
            game.AddCar(new Car(70, 35, "3", "Volga"));
            
            game.Run();
            Thread.Sleep(3000);

            game.GetTime();

            Car vinCar = game.getWinner();
            Thread.Sleep(1000);
            Console.SetCursorPosition(10, 48);
            Console.WriteLine($"First went the distance {vinCar.Model} during {vinCar.Time} seconds");

            // Delay.
            Console.Read();
        }
    }
}
