using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Напишите программу, в которой объявляется делегат для методов 
 * с двумя аргументами (символ и текст) и целочисленным результатом.
 * В главном классе необходимо описать два статических метода. 
 * Один статический метод результатом возвращает количество вхождений 
 * символа (первый аргумент) в текстовую строку (второй аргумент). 
 * Другой метод результатом возвращает индекс первого вхождения 
 * символа (первый аргумент) в текстовую строку (второй аргумент), 
 * или значение -1, если символ в текстовой строке не встречается.
 * В главном методе создать экземпляр делегата и с помощью этого 
 * экземпляра вызвать каждый из статических методов. */


namespace Task_2
{
    class Program
    {
        public delegate int CountSumbString(char c, string s);
        delegate void Symbol(char c);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            char c = 'о';
            string s = "У лукоморья дуб зеленый";

            CountSumbString countSumbString = CountSumbol;

            int result = countSumbString(c, s);
            Console.WriteLine(result);

            countSumbString = IndexFirst;

            result = countSumbString(c, s);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        public static int CountSumbol(char c, string s)
        {
            int num = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (c == s[i])
                    num++;
            }
            if (num == 0)
                return -1;
            return num;
        }
        public static int IndexFirst(char c, string s)
        {
            return s.IndexOf(c);
        }
    }
}
