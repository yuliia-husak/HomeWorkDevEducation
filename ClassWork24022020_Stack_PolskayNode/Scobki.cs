using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork24022020_Stack_PolskayNode
{
    public class Scobki
    {
        Stack<char> vs = new Stack<char>();

        string S { get; set; }

        public Scobki(string s)
        {
            this.S = s;           
        }

        public char[] MethodChar()
        {
            char[] stringChar = S.ToCharArray();

            return stringChar;
        }

        public void AnalisScobki()
        {
            char[] ch = MethodChar();

            foreach(char c in ch)
            {
                switch (c)
                {
                    case '(':
                    case '{':
                    case '[':
                        vs.Push(c);
                        break;                        
                }

                switch (c)
                {
                    case ')':
                        if (vs.Peek() == '(') vs.Pop();                       
                        break;
                    case '}':
                        if (vs.Peek() == '{') vs.Pop();
                        break;
                    case ']':
                        if (vs.Peek() == '[') vs.Pop();
                        break;
                }
            }

            if (vs.Count == 0) Console.WriteLine("Good!!!");
            else Console.WriteLine("Error");
        }
    }
}
