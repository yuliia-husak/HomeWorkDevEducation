using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();
            myStack.Push(2);
            myStack.Push(1);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(6);
            myStack.Push(7);
            myStack.Push(8);
            myStack.Push(9);
            Console.Write("myStack.Peek(): ");
            Console.WriteLine(myStack.Peek());

            Console.WriteLine("myStack.ShowStack(): ");
            myStack.ShowStack();


            Console.Write("myStack.Pop(): ");
            Console.WriteLine(myStack.Pop());

            Console.WriteLine("myStack.ShowStack(): ");
            myStack.ShowStack();



            myStack.Peek();

            Console.ReadKey();

        }
    }
}
