using System;
using System.Threading;

namespace CarRaling
{
    class CarBody
    {
        private readonly int left;
        private int top;

        public CarBody(int left, int top)
        {
            this.left = left;
            this.top = top;      
        }

        public void Draw(string n)
        {
            switch (n)
            {
                case "1":
                    Thread th1 = new Thread(DrawWheels);  // Отрисовка колес.
                    th1.Start();
                    th1.IsBackground = true;
                    Thread.Sleep(60);
                    Thread th2 = new Thread(DrawCarBody); // Отрисовка кузова.            
                    th2.Start();
                    th2.IsBackground = true;
                    Thread.Sleep(60);
                    break;

                case "2":
                    Thread th3 = new Thread(DrawWheels);  // Отрисовка колес.
                    th3.Start();
                    th3.IsBackground = true;
                    Thread.Sleep(60);
                    Thread th4 = new Thread(DrawCarBody); // Отрисовка кузова.            
                    th4.Start();
                    th4.IsBackground = true;
                    Thread.Sleep(60);
                    break;

                case "3":
                    Thread th5 = new Thread(DrawWheels);  // Отрисовка колес.
                    th5.Start();
                    th5.IsBackground = true;
                    Thread.Sleep(60);
                    Thread th6 = new Thread(DrawCarBody); // Отрисовка кузова.            
                    th6.Start();
                    th6.IsBackground = true;
                    Thread.Sleep(60);
                    break;
            }
            
        }

        private void DrawCarBody()
        {
            Console.SetCursorPosition(left, top);
            Console.BackgroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(" ");
                }
                top++;
                Console.SetCursorPosition(left, top);
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }

        private void DrawWheels()
        {
            Console.BackgroundColor = ConsoleColor.Gray;

            Console.SetCursorPosition(left - 1, top + 1);
            Console.Write(" ");
            Console.SetCursorPosition(left - 1, top + 2);
            Console.Write(" ");

            Console.SetCursorPosition(left - 1, top + 7);
            Console.Write(" ");
            Console.SetCursorPosition(left - 1, top + 8);
            Console.Write(" ");

            Console.SetCursorPosition(left + 10, top + 1);
            Console.Write(" ");
            Console.SetCursorPosition(left + 10, top + 2);
            Console.Write(" ");

            Console.SetCursorPosition(left + 10, top + 7);
            Console.Write(" ");
            Console.SetCursorPosition(left + 10, top + 8);
            Console.Write(" ");

            Console.BackgroundColor = ConsoleColor.Black;
        }
        
    }
}
