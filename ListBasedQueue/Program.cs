using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBasedQueue
{  
    class Program
    {
        static void Main(string[] args)
        {
            MyQeque<int> myQeque = new MyQeque<int>();

            myQeque.Enqueue(1);    
            myQeque.Enqueue(2);    
            myQeque.Enqueue(3);   
            myQeque.Enqueue(4);
            myQeque.Enqueue(5);
            Console.WriteLine(new string('-', 20));
            myQeque.Show();
            Console.WriteLine(new string('-', 20));

            Console.WriteLine(myQeque.Peek()); 
            Console.WriteLine(myQeque.Dequeue());
            Console.WriteLine(new string('-', 20));
            myQeque.Show();
            Console.WriteLine(new string('-', 20));

            myQeque.Enqueue(6);     
            myQeque.Enqueue(7);     
            myQeque.Enqueue(8);
            Console.WriteLine(new string('-', 20));
            myQeque.Show();
            Console.WriteLine(new string('-', 20));

            Console.WriteLine(myQeque.Peek()); 
            Console.WriteLine(myQeque.Dequeue());
            Console.WriteLine(new string('-', 20));
            myQeque.Show();
            Console.WriteLine(new string('-', 20));

            Console.ReadKey();
        }
    }
}
