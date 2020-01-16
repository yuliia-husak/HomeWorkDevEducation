using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_001_Classes
{
    class Triangle
    {
        //o	Поля:
        private int a;
        private int b;
        private int c;

        public Triangle() { a = b = c = 0; }

        //o	Конструктор, позволяющий создать экземпляр класса с заданными длинами сторон.
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        //o	Методы, позволяющие:
        //▪	вывести длины сторон треугольника на экран;
        public void ShowTriangle()
        {
            Console.WriteLine("Your triangle with side a: {0}, b: {1}, c: {2}", a, b, c);
        }
        //▪	рассчитать периметр треугольника;
        int Perimetr2()
        {
            return a + b + c;
        }
        public int PerCount
        {
            get
            {
                return this.Perimetr2();
            }
        }

        //▪	рассчитать площадь треугольника.
        double Area()
        {
            double p = ((a + b + c) * 1.0 / 2);
            double res = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return res;
        }
        public double AreaCount
        {
            get
            {
                return this.Area();
            }
        }

        //o	Свойства:
        //▪	позволяющее получить-установить длины сторон треугольника (доступное для чтения и записи);
        public int A
        {
            get => a;
            set => a = value;
        }

        public int B
        {
            get => b;
            set => b = value;
        }

        public int C
        {
            get => c;
            set => c = value;
        }

        //▪	позволяющее установить, существует ли треугольник с данными длинами сторон (доступное только для чтения).
        public bool IsTriangle
        {
            get
            {
                if (a + b > c && a + c > b && b + c > a)
                { return true; }
                return false;
            }
        }

        

    }
}
