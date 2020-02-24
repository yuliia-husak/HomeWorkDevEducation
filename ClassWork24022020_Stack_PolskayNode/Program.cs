using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork24022020_Stack_PolskayNode
{
    class Program
    {
        static void Main(string[] args)
        {
            Note note = new Note();

            string s = "(8+3)-(5+1)";           

            note.ConvertToPostfixNotation(s);           
            Console.WriteLine(note.result(s));

            Scobki scobki = new Scobki("({a+b}-[c+d])");

            scobki.AnalisScobki();            

            Console.ReadKey();
        }
    }
}
