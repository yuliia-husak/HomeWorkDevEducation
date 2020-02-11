using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Delegate
{    
        delegate string StrMod(string str);
        public class DelegateTest
        {
            //Заменить пробелы дефисами
            public static string ReplaceSpaces(string s)
            {
                Console.WriteLine("Замена пробелов дефисами.");
                return s.Replace(' ', '-');
            }

            //Удалить пробелы
            static string RemoveSpaces(string s)
            {
                string temp = "";
                int i;
                Console.WriteLine("Удаление пробелов.");
                for (i = 0; i < s.Length; i++)
                {
                    if (s[i] != ' ') temp += s[i];
                }

                return temp;
            }


            //обратить строку
            static string Reverse(string s)
            {
                string temp = "";
                int i, j;
                Console.WriteLine("Обращение строки.");
                for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
                    temp += s[i];
                return temp;
            }
        }
    }

