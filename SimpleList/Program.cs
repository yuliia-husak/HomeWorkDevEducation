using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleList
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }
    class Program
    {
        private static void ShowList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
        static void Main(string[] args)
        {
            Node node = new Node();
            node.Value = 5;

            Node node2 = new Node();
            node2.Value = 6;

            node.Next = node2;


            Node node3 = new Node();
            node3.Value = 7;
            node2.Next = node3;
            
            ShowList(node2);

            Console.ReadLine();
        }
    }
}
