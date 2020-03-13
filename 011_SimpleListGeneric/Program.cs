using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_SimpleListGeneric
{
    public class SimpleListGeneric<T>
    {
        public SimpleListGeneric(T value)
        {
            Value = value;
        }
        public T Value { get; set; }
        public SimpleListGeneric<T> Next { get; set; }
    }
    class Program
    {
        public static void ShowList(SimpleListGeneric<string> simple)
        {
            while (simple != null)
            {
                Console.WriteLine(simple.Value);
                simple = simple.Next;
            }
        }
        static void Main(string[] args)
        {
            SimpleListGeneric<string> first = new SimpleListGeneric<string>("First");
            SimpleListGeneric<string> second = new SimpleListGeneric<string>("second");

            first.Next = second;

            Console.WriteLine(first);
            Console.WriteLine(first.Value);
            Console.WriteLine(first.Next.Value);            
            Console.WriteLine(second.Value);
            Console.WriteLine("-----------------");
            ShowList(first);


            Console.ReadLine();
        }
    }
}
