using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork18032020_AVLTree
{
    class Program
    {
        static void Main(string[] args)
        {
            AVLTree<int> instance = new AVLTree<int>();

            instance.Add(21);
            instance.Add(10);
            instance.Add(28);
            instance.Add(6);
            instance.Add(15);
            instance.Add(25);
            instance.Add(32);
            instance.Add(3);
            instance.Add(9);
            instance.Add(12);
            instance.Add(18);
            instance.Add(23);
            instance.Add(26);
            instance.Add(30);
            instance.Add(34);
            instance.Add(7);
            instance.Add(17);
            instance.Add(24);
            instance.Add(29);

            Console.WriteLine("\nСимметричный обход: ");
            foreach (var i in instance)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n ");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("\nПрямой обход: ");
            instance.preorderPrint(instance.Head);
            Console.WriteLine("\n ");
            Console.WriteLine(new string('-', 50));

            AVLTree<int> instance2 = new AVLTree<int>
            {
                8,15,20,10
            };

            foreach (var i in instance2)
            {
                Console.Write(i + " ");
            }


            Console.ReadKey();
        }
    }
}
