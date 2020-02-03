using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_03022020
{
    
    class Program
    {
        //class MyList
        //{
        //    public int key; //ключ  
        //    public MyList Next; //указатель на след.элемент
        //    public MyList() { this.Next = null; }
        //    public MyList(int key, MyList Next)
        //    {
        //        this.key = key;
        //        this.Next = Next;
        //    }           
            
        //}

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // MyList myList = new MyList();

            // MyList p = null, head = null; 

            // int count = 4;

            // Console.WriteLine("ввод элементов списка " + count);
            // for (int i = 1; i <= count; i++)
            // {
            //     if (i == 1)
            //     {
            //         head = myList;
            //         head.key = Int32.Parse(Console.ReadLine());
            //         head.Next = null;
            //         p = head;
            //     }
            //     else
            //     {
            //         p.Next = myList;
            //         p = p.Next;
            //         p.key = Int32.Parse(Console.ReadLine());
            //         p.Next = null;
            //     }
            // }

            //for(int i = 0; i < myList.key; i++)
            //{
            //     Console.WriteLine(myList.Next);

            //}

            

            Car car = new Car("Ford Focus", 5, 4.6);
            car.Drive(10);
            car.Drive(5);
            car.Drive(90);
            car.Drive(100);

            

            Console.ReadKey();
        }
    }
}
