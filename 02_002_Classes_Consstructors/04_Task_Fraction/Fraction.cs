using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_002_Classes_Consstructors._04_Task_Fraction
{
    class Fraction
    {
        int numerator;
        int denominator;

        public Fraction()
        {
            Console.WriteLine("Enter numerator: ");
            numerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter denominator: ");
            denominator = int.Parse(Console.ReadLine());
        }

        public Fraction(int x, int y)
        {
            numerator = x;

            denominator = y;
        }

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }


        // Статический метод.        
        public Fraction Sum(Fraction x, Fraction y)
        {
            Console.WriteLine("Sum fraction ({0}/{1}) and ({2}/{3}) = ({4}/{5}).",
                x.Numerator, x.Denominator, y.Numerator, y.Denominator,
                x.Numerator + y.Numerator, y.Denominator + y.Denominator);

            return new Fraction();
        }

        // Статический метод.
        public static void Sub(Fraction x, Fraction y)
        {

            Console.WriteLine("Sub fraction ({0}/{1}) and ({2}/{3}) = ({4}/{5}).",
                x.Numerator, x.Denominator, y.Numerator, y.Denominator,
                x.Numerator - y.Numerator, y.Denominator - y.Denominator);
        }

        // Статический метод.
        public static void Div(Fraction x, Fraction y)
        {
            Console.WriteLine("Div fraction ({0}/{1}) and ({2}/{3}) = ({4}/{5}).",
                 x.Numerator, x.Denominator, y.Numerator, y.Denominator,
                 x.Numerator * y.Denominator, x.Denominator * y.Numerator);
        }

        // Статический метод.
        public static void Multi(Fraction x, Fraction y)
        {
            Console.WriteLine("Multi fraction ({0}/{1}) and ({2}/{3}) = ({4}/{5}).",
                x.Numerator, x.Denominator, y.Numerator, y.Denominator,
                x.Numerator * y.Numerator, y.Denominator * y.Denominator);
        }

        // Статический метод.
        public static void MinFraction(Fraction x, Fraction y)
        {
            if (x.Denominator <= y.Denominator && x.Numerator <= y.Numerator)
                Console.WriteLine("MinFraction fraction ({0}/{1}) and ({2}/{3}) = ({4}/{5}).",
                    x.Numerator, x.Denominator, y.Numerator, y.Denominator,
                    x.Numerator, x.Denominator);
            else
                Console.WriteLine("MinFraction fraction ({0}/{1}) and ({2}/{3}) = ({4}/{5}).",
                    x.Numerator, x.Denominator, y.Numerator, y.Denominator,
                    y.Numerator, y.Denominator);
        }

        // Статический метод.
        public static void MaxFraction(Fraction x, Fraction y)
        {
            if (x.Denominator >= y.Denominator && x.Numerator >= y.Numerator)
                Console.WriteLine("MinFraction fraction ({0}/{1}) and ({2}/{3}) = ({4}/{5}).",
                    x.Numerator, x.Denominator, y.Numerator, y.Denominator,
                    x.Numerator, x.Denominator);
            else
                Console.WriteLine("MinFraction fraction ({0}/{1}) and ({2}/{3}) = ({4}/{5}).",
                    x.Numerator, x.Denominator, y.Numerator, y.Denominator,
                    y.Numerator, y.Denominator);
        }

        // Статический метод.
        public static void CommonDenom(Fraction x, Fraction y)
        {
            int commonD = 0;

            if (x.Denominator == y.Denominator)
                Console.WriteLine("CommonDenom fraction ({0}/{1}) and ({2}/{3}) = ({4}).",
                    x.Numerator, x.Denominator, y.Numerator, y.Denominator,
                    y.Denominator);
            else if (x.Denominator > y.Denominator)
            {
                for (int i = 2; i < y.Denominator / 2; i++)
                {
                    int a = x.Denominator * i;
                    int b = y.Denominator * i;

                    if (a == b)
                        commonD = x.Denominator;
                    Console.WriteLine("CommonDenom fraction ({0}/{1}) and ({2}/{3}) = ({4}).",
                    x.Numerator, x.Denominator, y.Numerator, y.Denominator,
                    commonD);
                    return;
                }

            }

            else
                for (int i = 2; i < y.Denominator / 2; i++)
                {
                    int a = x.Denominator * i;
                    int b = y.Denominator * i;

                    if (a == b)
                        commonD = x.Denominator;
                    Console.WriteLine("CommonDenom fraction ({0}/{1}) and ({2}/{3}) = ({4}).",
                    x.Numerator, x.Denominator, y.Numerator, y.Denominator,
                    commonD);
                    return;
                }

        }

        // Статический метод.
        public static void ReduceFraction(Fraction x, Fraction y)
        {
            Console.WriteLine("ReduceFraction ({0}/{1}) and ({2}/{3}) = ({4}/{5}).",
                x.Numerator, x.Denominator, y.Numerator, y.Denominator,
                x.Numerator * y.Numerator, y.Denominator * y.Denominator);
        }

        // Статический метод.
        public void SelectWhole(Fraction x, Fraction y)
        {
            Console.WriteLine("SelectWhole fraction ({0}/{1}) and ({2}/{3}) = ({4}/{5}).",
                x.Numerator, x.Denominator, y.Numerator, y.Denominator,
                x.Numerator * y.Numerator, y.Denominator * y.Denominator);
        }

        // Статический метод.
        public void CheckEqual(Fraction x, Fraction y)
        {
            bool chek = false;
            if (x.Denominator == y.Denominator && x.Numerator == y.Numerator)
            {
                chek = true;
                Console.WriteLine("CheckEqual fraction ({0}/{1}) and ({2}/{3}) = ({4}).",
                x.Numerator, x.Denominator, y.Numerator, y.Denominator,
                chek);
            }
            else
                Console.WriteLine("CheckEqual fraction ({0}/{1}) and ({2}/{3}) = ({4}).",
                x.Numerator, x.Denominator, y.Numerator, y.Denominator,
                chek);
        }
    }
}

