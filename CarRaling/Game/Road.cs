using System;
using System.Threading;

namespace CarRaling
{
    class Road
    {
        private readonly int left = 0;        
        public Road(int left = 0)
        {
            this.left = left;           
        }

        public void DrawRoad()
        {
            for (int j = 0; j < 45; j++)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.SetCursorPosition(left, j);      // Левая полоса 0
                Console.Write(" ");

                Console.SetCursorPosition(left + 30, j); // Правая полоса
                Console.Write(" ");

                Console.SetCursorPosition(left + 60, j); // Правая полоса 0
                Console.Write(" ");

                Console.SetCursorPosition(left + 90, j); // Правая полоса 0
                Console.Write(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }       
    }
}
