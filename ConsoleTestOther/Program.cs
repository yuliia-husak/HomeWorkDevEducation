using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestOther
{
    class Program
    {
        delegate int Operation(char c, string s);
        delegate void Symbol(char c);
        static void Main(string[] args)
        {
            char c = 'o';
            string s = "hello world";
            Operation del = Entrance;
            int result = del(c, s);
            Console.WriteLine(result);
            del = Index;
            result = del(c, s);
            Console.WriteLine(result);
            Console.Read();
        }

        private static void Add(char c)
        {
            Console.WriteLine(c);
        }

        //1
        private static int Entrance(char c, string s)
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
        private static int Index(char c, string s)
        {
            return s.IndexOf(c);
        }
    }
}
