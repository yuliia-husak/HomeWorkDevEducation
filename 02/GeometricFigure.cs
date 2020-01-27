using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_006_HomeTask_AbstractFigure
{
    abstract class GeometricFigure
    {
        public abstract double Area();
        public abstract double Perimetr();

        public abstract void Draw();

        public abstract void Info();
    }
}
