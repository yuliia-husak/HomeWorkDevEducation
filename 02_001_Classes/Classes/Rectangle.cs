using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_001_Classes
{
    class Rectangle
    {
        //o	Поля:
        private int a;
        private int b;

        //o Конструктор, позволяющий создать экземпляр класса с заданными длинами сторон.
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        //o Методы, позволяющие:
        //▪	вывести длины сторон прямоугольника на экран;
        public void ShowRectangle()
        {
            Console.WriteLine("Width your rectangle: {0} cm. ", a);
            Console.Write("Length your rectangle: {0} cm. ", b);
        }
        //▪	рассчитать периметр прямоугольника;
        int PerRec()
        {
            return (a + b) * 2;
        }

        public int PerimetrRes
        {
            get
            {
                return this.PerRec();
            }
        }
        //▪	рассчитать площадь прямоугольника.
        private int AreaR()
        {
            return a * b;
        }

        public int AreaRes
        {
            get
            {
                return this.AreaR();
            }
        }

        //o Свойства:
        //▪	получить-установить длины сторон прямоугольника(доступное для чтения и записи);
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

        //▪	позволяющее установить, является ли данный прямоугольник квадратом(доступное только для чтения).
        public bool IsSquare
        {
            get
            {
                if (a == b) 
                { return true; }
                return false;
            }
        }

    }
}
