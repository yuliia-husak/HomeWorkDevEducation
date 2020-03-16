using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BTree_TDD
{
    public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> _head;
        private int _count;

        #region Добавление нового узла дерева

        public void Add(T value)
        {
            // Первый случай: дерево пустое     

            if (_head == null)
            {
                _head = new BinaryTreeNode<T>(value);
            }

            // Второй случай: дерево не пустое, поэтому применяем рекурсивный алгорит 
            //                для поиска места добавления узла        

            else
            {
                AddTo(_head, value);
            }
            _count++;
        }

        // Рекурсивный алгоритм 
        private void AddTo(BinaryTreeNode<T> node, T value)
        {
            // Первый случай: значение добавляемого узла меньше чем значение текущего. 

            if (value.CompareTo(node.Value) < 0)
            {
                // если левый потомок отсутствует - добавляем его          

                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T>(value);
                }
                else
                {
                    // повторная итерация               
                    AddTo(node.Left, value);
                }
            }
            // Второй случай: значение добавляемого узла равно или больше текущего значения      
            else
            {
                // Если правый потомок отсутствует - добавлем его.          

                if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T>(value);
                }
                else
                {
                    // повторная итерация

                    AddTo(node.Right, value);
                }
            }
        }

        #endregion

        //нумератор
        public IEnumerator<T> GetEnumerator()
        {
            return InOrderTraversal();
            //return LevelOrderPrint();
            
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count
        {
            get { return _count; }
        }

        //симметричный вывод
        public IEnumerator<T> InOrderTraversal()
        {
            if (_head != null)
            {
                Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
                BinaryTreeNode<T> current = _head;

                bool goLeftNext = true;

                stack.Push(current);

                while (stack.Count > 0)
                {
                    if (goLeftNext)
                    {
                        while (current.Left != null)
                        {
                            stack.Push(current);
                            current = current.Left;
                        }
                    }
                    yield return current.Value;

                    if (current.Right != null)
                    {
                        current = current.Right;
                        goLeftNext = true;
                    }
                    else
                    {
                        current = stack.Pop();
                        goLeftNext = false;
                    }
                }
            }
        }


        //вывод по вершинам с корня слева направо
        public IEnumerator<T> LevelOrderPrint()
        {
            if (_head != null)
            {
                Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
                
                queue.Enqueue(_head);

                while (queue.Count!=0)
                {
                    BinaryTreeNode<T> temp = queue.Dequeue();

                    yield return temp.Value;

                    if (temp.Left != null)
                        queue.Enqueue(temp.Left);

                    if (temp.Right != null)
                        queue.Enqueue(temp.Right);                   
                }
            }
        }

        public void PreorderPrint()
        {
            int amountL = 0;
            int amountR = 0;
            if (_head != null)
            {
                Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();

                queue.Enqueue(_head);

                while (queue.Count != 0)
                {
                    BinaryTreeNode<T> temp = queue.Dequeue();

                    if (temp.Left != null)
                    {
                        Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
                        BinaryTreeNode<T> current = temp.Left;                        

                        bool goLeftNext = true;

                        stack.Push(current);

                        while (stack.Count > 0)
                        {
                            if (goLeftNext)
                            {
                                while (current.Left != null)
                                {
                                    stack.Push(current);
                                    amountL++;
                                    current = current.Left;
                                }
                            }

                            amountL++;
                            if (current.Right != null)
                            {
                                current = current.Right;
                                goLeftNext = true;
                            }
                            else
                            {
                                current = stack.Pop();
                                goLeftNext = false;
                            }
                        }
                        queue.Enqueue(temp.Left);

                        if (temp.Right != null)
                        {
                            Stack<BinaryTreeNode<T>> stackR = new Stack<BinaryTreeNode<T>>();
                            BinaryTreeNode<T> currentr = temp.Right;                            

                            goLeftNext = true;

                            stack.Push(current);

                            while (stack.Count > 0)
                            {
                                if (goLeftNext)
                                {
                                    while (current.Left != null)
                                    {
                                        stack.Push(current);
                                        current = current.Left;
                                    }
                                }
                                
                                amountR++;

                                if (current.Right != null)
                                {
                                    current = current.Right;
                                    goLeftNext = true;
                                }
                                else
                                {
                                    current = stack.Pop();
                                    goLeftNext = false;
                                }
                            }
                        }
                        queue.Enqueue(temp.Right);
                        if (amountL != amountR)
                        {
                            Console.WriteLine(temp.Value);
                        }
                        
                    }
                }
            }
        }


        #region Удаление дерева

        public void Clear()
        {
            _head = null;
            _count = 0;
        }

        #endregion


        public IEnumerator<T> SumAllElement()
        {
            BinaryTreeNode<T> current = _head;

            yield return current.Value;
        }

        public override string ToString()
        {
            return string.Format(_head.ToString());
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
            PrintTree(_head);
        }

        /// <summary>
        /// Вывод бинарного дерева начиная с указанного узла
        /// </summary>
        /// <param name="startNode">Узел с которого начинается печать</param>
        /// <param name="indent">Отступ</param>
        /// <param name="side">Сторона</param>
        private void PrintTree(BinaryTreeNode<T> startNode, string indent = "", Side ? side = null)
        {
            if (startNode != null)
            {
                var nodeSide = _head == null ? "+" : _head == _head.Left ? "L" : "R";
                Console.WriteLine($"{indent} [{nodeSide}]- {startNode.Value}");
                indent += new string(' ', 3);
                //рекурсивный вызов для левой и правой веток
                PrintTree(startNode.Left, indent, Side.Left);
                PrintTree(startNode.Right, indent, Side.Right);
            }
        }
    }
}
