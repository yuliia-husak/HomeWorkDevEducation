using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BTree_TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> instance = new BinaryTree<int>();

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
            instance.Add(26);//26
            instance.Add(30);
            instance.Add(34);
            instance.Add(7);
            instance.Add(17);//17
            instance.Add(24);
            instance.Add(29);

            foreach (var i in instance)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Вершины с неравными потомками: ");
            instance.BranchComprarisonChild();

            Console.WriteLine("\n---------------------------");
            Console.Write("Amount number 9 in tree: ");
            int a= instance.AmountNumber(9);
            Console.WriteLine(a);

            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Есть ли данные в дереве одиннаковые: ");
            if (instance.MaxIdentical()) Console.WriteLine(instance.MaxIdentical());
            else Console.WriteLine("No identical");

            Console.WriteLine("\n---------------------------");
            Console.Write("Максимальное число одиннаковых данных ");
            int b = instance.MaxCountIdentical();
            Console.WriteLine(b);

            Console.WriteLine("\n---------------------------");
            Console.Write("This tree symetrical: ");
            Console.WriteLine(instance.TreeSymetrical());

            Console.WriteLine("\n---------------------------");
            Console.Write("Сумма всех элементов на 3 уровне: ");
            Console.WriteLine(instance.SumElementLevel());

            Console.WriteLine("\n---------------------------");
            Console.Write("Минимальное и максимальное значения на каждом уровне: ");
            instance.FindMinMax();


            Console.WriteLine("\n---------------------------");
            Console.Write("Вывод путей на экран: \n");
            instance.WayTree();


            Console.ReadLine();
        }
    }
}
