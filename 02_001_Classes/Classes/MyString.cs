using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_001_Classes
{
    class MyString
    {
        //Поля:
        private StringBuilder Line;
        private int n;

        public int N
        { get { return n; } set { n = N; } }

        //Конструктор, позволяющий создать строку из n символов.
        public MyString(int n)
        {
            this.n = n;
            Line = new StringBuilder(n);
        }

        public MyString(int n, StringBuilder L)
        {
            if (L.Length <= n) Line = L;
            this.n = n;
        }

        //Методы, позволяющие:
        //подсчитать количество пробелов в строке;
        public int CountSpaces()
        {
            return Line.ToString().Count(x => x == ' ');
        }

        //заменить в строке все прописные символы на строчные;
        public StringBuilder StrLow()
        {
            for (int i = 0; i < Line.Length; ++i)
            {
                if (char.IsLetter(Line[i]) && char.IsLower(Line[i]))
                {
                    Line[i] = char.ToUpper(Line[i]);
                }
            }
            return Line;
        }

        //удалить из строки все знаки препинания.
        public void RemovePuncts()
        {
            string s = Line.ToString();
            Line.Clear();
            Line.Append(Regex.Replace(s, "[,.:?!]", ""));
            n = Line.Length;
        }

        public override string ToString()
        {
            return Line.ToString();
        }

        //Свойства:
        // -возвращает общее количество элементов в строке (доступное только для чтения);
        public string Size => $"Колличество элементов в строку {Line.Length}";

        //позволяющее установить значение поля, в соответствии с введенным значением строки с клавиатуры, а также получить значение данного поля(доступно для чтения и записи)

    }
}
