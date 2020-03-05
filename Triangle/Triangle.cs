using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    struct Point
    {
        public double x { get; set; }
        public double y { get; set; }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }   
    }

    class Triangle
    {
        public Point a { get; set; }
        public Point b { get; set; }
        public Point c { get; set; }

        public double AB { get; set; } 
        public double BC { get; set; } 
        public double AC { get; set; }

        static bool ok;       

        public Triangle(Point a, Point b, Point c)
        {
            double AB = Math.Sqrt((Math.Pow((a.x - (b.x)), 2)) + (Math.Pow((a.y - (b.y)), 2)));
            double BC = Math.Sqrt((Math.Pow((c.x - (b.x)), 2)) + (Math.Pow((c.y - (b.y)), 2)));
            double AC = Math.Sqrt((Math.Pow((a.x - (c.x)), 2)) + (Math.Pow((a.y - (c.y)), 2)));

            if ((AB - BC) > AC && AC > (AB + BC))
            {
                ok = false;
                throw new ArgumentException("Error triangle.");
            }
            ok = true;
            if (ok)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                AB = Math.Sqrt((Math.Pow((a.x - (b.x)), 2)) + (Math.Pow((a.y - (b.y)), 2)));
                BC = Math.Sqrt((Math.Pow((c.x - (b.x)), 2)) + (Math.Pow((c.y - (b.y)), 2)));
                AC = Math.Sqrt((Math.Pow((a.x - (c.x)), 2)) + (Math.Pow((a.y - (c.y)), 2)));
            }                                 
        }

        public void sd_right(double d)   //сдвиг вправо
        {
            //a.x += d; b.x = +d; c.x = +d;
            
        }
        public void sd_left(double d)    //сдвиг влево
        {
            //a.x = -d; b.x = -d; c.x = -d;
        }
        public void sd_up(double d)  //сдвиг верх
        {
            //a.y = +d; b.y = +d; c.y = +d;
        }
        public void sd_down(double d)    //сдвиг вниз
        {
            //a.y = -d; b.y = -d; c.y = -d;
        }
        public double R(Point a, Point b)
        {
            return Convert.ToSingle(Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2)));
        }
        public void sd_alfa(double d)    //поворот на угол d
        {
            Point M = new Point((a.x + b.x + c.x) / 3, (a.y + b.y + c.y) / 3);
            //a.x = M.x + Convert.ToSingle(R(M, a) * Math.Cos(d));
            //a.y = M.y - Convert.ToSingle(R(M, a) * Math.Sin(d));
            //b.x = M.x + Convert.ToSingle(R(M, b) * Math.Cos(d));
            //b.y = M.y - Convert.ToSingle(R(M, b) * Math.Sin(d));
            //c.x = M.x + Convert.ToSingle(R(M, c) * Math.Cos(d));
            //c.y = M.y - Convert.ToSingle(R(M, c) * Math.Sin(d));
        }
        public void sd_rad(double r) //увелечение на r
        {
            double d = 0;
            Point M = new Point((a.x + b.x + c.x) / 3, (a.y + b.y + c.y) / 3);           
            //a.x = Convert.ToSingle((R(M, a) + r) * Math.Cos(d));
            //a.y = -Convert.ToSingle((R(M, a) + r) * Math.Sin(d));
            //b.x = Convert.ToSingle((R(M, b) + r) * Math.Cos(d));
            //b.y = -Convert.ToSingle((R(M, b) + r) * Math.Sin(d));
            //c.x = Convert.ToSingle((R(M, c) + r) * Math.Cos(d));
            //c.y = -Convert.ToSingle((R(M, c) + r) * Math.Sin(d));
        }

        public override string ToString()
        {
            return ToString("G");
        }

        public string ToString(string fmt)
        {
            if (string.IsNullOrEmpty(fmt))
                fmt = "G";

            switch (fmt.ToUpperInvariant())
            {
                case "G":
                    return string.Format("a(x,y) = {0},{1}\nb(x,y) = {2},{3}\nc(x,y) = {4},{5}",
                         a.x, a.y, b.x, b.y, c.x, c.y);
                case "D":
                    return string.Format("Lingth: A = {0}\tB = {1}\tC = {2}",
                         AB, BC, AC);                
                default:
                    string msg = string.Format("'{0}' is an invalid format string",
                                               fmt);
                    throw new ArgumentException(msg);
            }
        }
    }
}
