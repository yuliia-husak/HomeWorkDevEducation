using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPointLine
{
    class Point : Target
    {
        Line line = new Line();        

        public override void Draw()
        {
            line.LineDraw();
        }
    }
}
