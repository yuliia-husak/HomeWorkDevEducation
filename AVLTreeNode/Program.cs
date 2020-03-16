using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTreeNode
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

            foreach (var i in instance)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadKey();
        }
    }
}
