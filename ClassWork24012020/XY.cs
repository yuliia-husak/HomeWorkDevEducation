using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork24012020
{
    class XY
    {
        double p;
        double a;
        public double X { get; set; }
        public double Y { get; set; }

        public XY()
        {
            X = 0;
            Y = 0;
        }

        public XY(double a, double b)
        {
            X = a;
            Y = b;
        }

        const double pi = 3.14;
        public double R { get; set; }
        public double P
        {
            get {return p = 2 * pi * R; }
        }

        public double A
        {
            get { return a = X * Y; }
        }
    }
}
