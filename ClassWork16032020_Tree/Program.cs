using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork16032020_Tree
{
    class TreeNode<TNode> : IComparable<TNode> where TNode : IComparable<TNode>
    {
        public TNode Value { get; private set; }
        public TreeNode<TNode> Left { get; set; }
        public TreeNode<TNode> Right { get; set; }
        public TreeNode(TNode value)
        {
            Value = value;
        }
        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }
    }

    public class Tree<T> : IEnumerable<T> where T : IComparable<T>
    {
        TreeNode<T> root;
        private int _count;

        public void Add(T value)
        {
            if (root == null)
            {
                root = new TreeNode<T>(value);
            }

            else
            {
                AddTo(root, value);
            }
            _count++;
        }

        private void AddTo(TreeNode<T> root, T value)
        {
            if (value.CompareTo(root.Value) < 0)
            {
                if (root.Left == null)
                {
                    root.Left = new TreeNode<T>(value);
                }
                else
                {
                    AddTo(root.Left, value);
                }
            }

            else
            {
                if (root.Right == null)
                {
                    root.Right = new TreeNode<T>(value);
                }
                else
                {
                    AddTo(root.Right, value);
                }
            }

        }

        public bool Contains(T value)
        {
            return Find(value) != null;
        }

        
        private TreeNode<T> Find(T value)
        {

            TreeNode<T> current = root; 

            // Пока текщий узел на пустой 
            while (current != null)
            {
                int result = current.CompareTo(value); // сравнение значения текущего элемента с искомым значением

                if (result > 0)
                {
                    // Если значение меньшне текущего - переход влево 
                    current = current.Left;
                }
                else if (result < 0)
                {
                    // Если значение больше текщего - переход вправо             
                    current = current.Right;
                }
                else
                {
                    // Элемент найден      
                    break;
                }
            }
            return current;
        }
        

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }        

        public int Count
        {
            get { return _count; }
        }

        public override string ToString()
        {
            return String.Format(root.Value.ToString());
        }
        public enum Side
        {
            Left,
            Right
        }

        /// Вывод бинарного дерева
        /// </summary>
        public void PrintTree()
        {
            PrintTree(root);
        }

        /// <summary>
        /// Вывод бинарного дерева начиная с указанного узла
        /// </summary>
        /// <param name="startNode">Узел с которого начинается печать</param>
        /// <param name="indent">Отступ</param>
        /// <param name="side">Сторона</param>
        private void PrintTree(TreeNode<T> startNode, string indent = "", Side ? side = null)
        {
            if (startNode != null)
            {
                var nodeSide = root == null ? "+" : root == root.Left ? "L" : "R";
                Console.WriteLine($"{indent} [{nodeSide}]- {startNode.Value}");
                indent += new string(' ', 3);
                //рекурсивный вызов для левой и правой веток
                PrintTree(startNode.Left, indent, Side.Left);
                PrintTree(startNode.Right, indent, Side.Right);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Tree<int> ins = new Tree<int>();
            ins.Add(15);
            ins.Add(10);
            ins.Add(18);
            ins.Add(12);            

            Console.WriteLine(ins.Contains(10));

            ins.PrintTree();

            Console.ReadKey();
        }
    }
}
