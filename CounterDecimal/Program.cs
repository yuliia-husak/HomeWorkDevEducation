using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Описать класс, реализующий десятичный счетчик, который может увеличивать
///или уменьшать свое значение на единицу в заданном диапазоне.Предусмотреть
///инициализацию счетчика значениями по умолчанию и произвольными значе-
///ниями.Счетчик имеет два метода: увеличения и уменьшения, — и свойство, по-
///зволяющее получить его текущее состояние.При выходе за границы диапазона
///выбрасываются исключения.
///Написать программу, демонстрирующую все разработанные элементы класса.
///Плюс вывод в шестнадцатеричном формате
/// </summary>

namespace CounterDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Counter counter = new Counter();
                counter.Password();
               
                Console.WriteLine(counter.GetCount);

                Counter counter1 = new Counter(18, 15, 20);
                counter1.Password();
                Console.WriteLine(counter1.GetCount);

                counter.Rase();
                counter1.Rase();

                Console.WriteLine(counter.GetCount);
                counter.Password();
                Console.WriteLine(counter1.GetCount);
                counter1.Password();

                Console.WriteLine(new string('-', 50));
                Console.WriteLine(counter.ToString());
                Console.WriteLine(counter1.ToString());

                for(int i = counter.GetCount; i < counter.MaxDiapason; i++)
                {
                    Console.WriteLine(counter.ToString());
                    counter.Rase();
                }

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ParamName);
            }

            Console.ReadLine();
        }
    }
}
