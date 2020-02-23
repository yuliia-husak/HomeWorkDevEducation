using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Stask
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем массив
            string[] array = new string[5] { "Masha", "Rita", "Petya", "Lesha", "Vanya" };
            //ConsoleKeyInfo keyInfo;

            //создаем стек
            Stack<Person> speople = new Stack<Person>();
            for (int i = 0; i < array.Length; i++)
            {
                speople.Push(new Person() { Name = array[i] });

            }
            foreach (var item in speople)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('*', 50));

            //создаем очередь
            Queue<Person> qpeople = new Queue<Person>();
            for (int i = 0; i < array.Length; i++)
            {
                qpeople.Enqueue(speople.Pop());

                //--------2 variant--------- 
                //string temp = people.Peek();
                //people1.Enqueue(people.Pop());
                //people.Push(temp);
            }
            foreach (var item in qpeople)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('*', 50));
            foreach (var item in speople)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('*', 50));

            char ch;
            do
            {
                //Console.ReadKey();
                ch = Console.ReadKey(true).KeyChar;
                Console.WriteLine(qpeople.Dequeue());
            } while (qpeople.Count != 0 && ch != ' '/*keyInfo.Key==ConsoleKey.Spacebar*/);

            Console.ReadLine();
        }
    }
}
