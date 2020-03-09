using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTemplateMethodCookingRiceBuckwheat
{
    class Program
    {        
        static void Main(string[] args)
        {
            Cook cooking1 = new ConcreteCookRice();
            Cook cooking2 = new ConcreteCookBuckwheat();

            Console.WriteLine("***********Cooking rice***************");
            cooking1.TemplateMethod();

            Console.WriteLine("*********Cooking buckwheat************");
            cooking2.TemplateMethod();

            Console.ReadKey();
        }
    }
}
