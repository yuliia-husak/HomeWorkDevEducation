using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork27012020
{
    class DemoPoint:IDemo
    {
        protected int x;
        protected int y;
        public DemoPoint(int x, int y)
        {
            this.x = x; this.y = y;
        }

        public override string ToString()
        {
            Console.WriteLine("point :({0}, {1})", x, y);
            return base.ToString();
        }

        public double Dlina()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public void Show()
        {
            throw new NotImplementedException();
        }

        public double Slina()
        {
            throw new NotImplementedException();
        }

        public int X
        {
            get { return x; }
        }

        public int this[int i]
        {
            get
            {
                if (i == 0) return x;
                else if (i == 1) return y;
                else throw new Exception("недопустимое значение");
            }
            set
            {
                if (i == 0) x=value;
                else if (i == 1) y=value;
                else throw new Exception("недопустимое значение");
            }
        }
    }
}
