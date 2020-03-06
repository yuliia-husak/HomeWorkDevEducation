using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPointLine
{
    class Program
    {
        static void Main()
        {
            Target target = new Point();
            target.Draw();

            Console.ReadLine();
        }

        static void testLine(Line line)
        {
            line.LineDraw();
        }
    }
}
