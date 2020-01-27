using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Figure
{
    class ConsoleCanvas
    {
        private char[][] canvas;
        int SIZE;

        public ConsoleCanvas(int size)
        {
            canvas = new char[SIZE = size][];
            for (int y = 0; y < canvas.Length; y++)
            {
                canvas[y] = new char[SIZE];
                for (int x = 0; x < canvas[y].Length; x++) canvas[y][x] = ' ';
            }
        }

        public void plot(int x, int y)
        {
            if ((x >= SIZE) || (y >= SIZE) || (x < 0) || (y < 0)) return;
            canvas[y][x] = '#';
        }

        public void line(int x1, int x2, int y1, int y2)
        {
            double dx = x2 - x1;
            if (dx == 0) { for (var y = y1; y < y2; y++) plot(x1, y); return; }
            double dy = y2 - y1;
            for (var x = x1; x <= x2; x++)
            {
                double y = y1 + dy * (x - x1) / dx;
                plot((int)x, (int)Math.Round(y));
            }
        }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            for (int y = 0; y < canvas.Length; y++)
            {
                for (int x = 0; x < canvas[y].Length; x++) sb.Append(canvas[y][x]);
                sb.AppendLine();
            }
            return sb.ToString();
        }

    }
}
