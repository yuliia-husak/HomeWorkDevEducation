using System;
using System.Threading;

namespace CarRaling
{
    class Road
    {
        private readonly int left = 0;
        public int speed = 5;
        public Road(int left = 0)
        {
            this.left = left;           
        }

        public void Movie()
        {
            Thread th = new Thread(DrawRoad);
            th.Start();
            th.IsBackground = true;
        }

        public void DrawRoad()
        {
            while (true)
            {
                if (this.speed != 0)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        int top = c;

                        // Очистка старой полосы
                        for (int j = 0; j < 45; j++)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.SetCursorPosition(left, j);      // Левая полоса
                            Console.Write(" ");

                            Console.SetCursorPosition(left + 30, j); // Правая полоса
                            Console.Write(" ");


                            Console.SetCursorPosition(left + 60, j); // Правая полоса
                            Console.Write(" ");


                            Console.SetCursorPosition(left + 90, j); // Правая полоса
                            Console.Write(" ");
                        }

                        // Рисование новой полосы
                        for (int k = 0; k < 15; k++)
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;

                            Console.SetCursorPosition(left, top);        // Левая полоса
                            Console.Write(" ");

                            Console.SetCursorPosition(left + 30, top); // Правая полоса
                            Console.Write(" ");

                            Console.SetCursorPosition(left + 60, top); // Правая полоса 0
                            Console.Write(" ");

                            Console.SetCursorPosition(left + 90, top); // Правая полоса 0
                            Console.Write(" ");

                            top = top + 3;
                            Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Thread.Sleep(this.speed);
                    }
                }
            }
            //for (int j = 0; j < 45; j++)
            //{
            //    Console.BackgroundColor = ConsoleColor.Gray;
            //    Console.SetCursorPosition(left, j);      // Левая полоса 0
            //    Console.Write(" ");

            //    Console.SetCursorPosition(left + 30, j); // Правая полоса
            //    Console.Write(" ");

            //    Console.SetCursorPosition(left + 60, j); // Правая полоса 0
            //    Console.Write(" ");

            //    Console.SetCursorPosition(left + 90, j); // Правая полоса 0
            //    Console.Write(" ");
            //}
            //Console.BackgroundColor = ConsoleColor.Black;
        }       
    }
}
