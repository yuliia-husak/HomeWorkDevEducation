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


        //находим колличество заданного числа
        internal int AmountNumber(T value)
        {
            int doublenumber=0;            

            BinaryTreeNode<T> current = _head;
            BinaryTreeNode<T> parent;
            parent = null;

            while (current != null)
            {
                int result = current.CompareTo(value);
                if (result > 0)
                {
                    // Если искомое значение меньше значение текущего узла - переходим к левому потомку.             

                    parent = current;
                    current = current.Left;
                }
                else if (result < 0)
                {
                    // Если искомое значение больше значение текущего узла - переходим к правому потомку.

                    parent = current;
                    current = current.Right;
                }                
                else
                {
                    parent = current;
                    current = current.Right;
                    doublenumber++;
                    // Искомый элемент найден             
                    
                }
            }            
            return doublenumber;     
        }

        internal bool TreeSymetrical()
        {
            if (_head != null)
            {
                Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();

                queue.Enqueue(_head);

                while (queue.Count != 0)
                {
                    BinaryTreeNode<T> temp = queue.Dequeue();

                    if ((temp.LeftHeight - temp.RightHeight)>1 || (temp.LeftHeight - temp.RightHeight) < -1)
                    {
                        return false;
                    }

                    if (temp.Left != null)
                        queue.Enqueue(temp.Left);

                    if (temp.Right != null)
                        queue.Enqueue(temp.Right);
                }
                return true;
            }
            return false;
        }

        //-------------------------------------------------

            //высота произвольного дерева
        int HeightTree(BinaryTreeNode<T> node)
        {
            if (node == null) return -1;
            else
            {
                int i, j;
                i = HeightTree(node.Left);
                j = HeightTree(node.Right);
                if (i > j) return i + 1;
                return j + 1;
            }
        }

        //определение колличества элементов на к-м уровне дерева
        int CountElement(BinaryTreeNode<T> node, int level, int k)
        {
            if (node == null || level > k) return 0;
            else
                if (level == k) return 1;
            else
                return CountElement(node.Left, level + 1, k) + CountElement(node.Right, level + 1, k);
        }
        public int LevelMaxElement()
        {
            BinaryTreeNode<T> node = _head;
            int maxElement = CountElement(node, 0, 1);

            return maxElement;
        }
        //--------------------------------------------
        internal int MaxCountIdentical()
        {
            int maxCount = 0;
            if (_head != null)
            {
                Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();

                queue.Enqueue(_head);

                while (queue.Count != 0)
                {
                    BinaryTreeNode<T> temp = queue.Dequeue();

                    if ((AmountNumber(temp.Value)) > 1)
                    {
                       if(maxCount < (AmountNumber(temp.Value))) maxCount = (AmountNumber(temp.Value));
                    }

                    if (temp.Left != null)
                        queue.Enqueue(temp.Left);

                    if (temp.Right != null)
                        queue.Enqueue(temp.Right);
                }
            }

            return maxCount;
        }

        internal bool MaxIdentical()
        {
            if (_head != null)
            {
                Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();

                queue.Enqueue(_head);

                while (queue.Count != 0)
                {
                    BinaryTreeNode<T> temp = queue.Dequeue();

                    if((AmountNumber(temp.Value))>1) return true;

                    if (temp.Left != null)
                        queue.Enqueue(temp.Left);

                    if (temp.Right != null)
                        queue.Enqueue(temp.Right);
                }
            }

            return false;
        }

        //------------------------------------------------------------------------
        /// <summary>
        /// Рекурсивный поиск
        /// </summary>
        /// <param name="node"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        int Search(BinaryTreeNode<T> node, T x)
        {
            if (node == null) return 0;
            else if ((node.CompareTo(x) == 0)) { return 1; }
            else if (node.CompareTo(x) > 0) return Search(node.Left, x);
            else
                return Search(node.Right, x);
        }

        public bool SSS(T value)
        {
            BinaryTreeNode<T> node = _head;            
            if ((Search(node, value)) == 1) return true;
            else return false;
        }
        //------------------------------------------------------------------------


        //------------------------------------------------------------------------
        /// <summary>
        /// Итеративный поиск элемента
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Contains(T value)
        {
            BinaryTreeNode<T> parent;
            return FindWithParent(value, out parent) != null;
        }

        private BinaryTreeNode<T> FindWithParent(T value, out BinaryTreeNode<T> parent)
        {
            // Поиск значения в дереве.     

            BinaryTreeNode<T> current = _head;
            parent = null;

            while (current != null)
            {
                int result = current.CompareTo(value);
                if (result > 0)
                {
                    // Если искомое значение меньше значение текущего узла - переходим к левому потомку.             

                    parent = current;
                    current = current.Left;
                }
                else if (result < 0)
                {
                    // Если искомое значение больше значение текущего узла - переходим к правому потомку.

                    parent = current;
                    current = current.Right;
                }
                else
                {
                    // Искомый элемент найден             
                    break;
                }
            }
            return current;
        }
        //------------------------------------------------------------------------
        #endregion

        //нумератор
        public IEnumerator<T> GetEnumerator()
        {
            //return InOrderTraversal();
            return LevelOrderPrint();
            
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

        public int BranchComprarisonChild()
        {
            int CountChild = 0;
            if (_head != null)
            {
                Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();

                queue.Enqueue(_head);

                while (queue.Count != 0)
                {
                    BinaryTreeNode<T> temp = queue.Dequeue();

                    if (temp.LeftHeight != temp.RightHeight)
                    {
                        Console.Write(temp.Value + " ");
                        CountChild++;
                    }

                    if (temp.Left != null)
                        queue.Enqueue(temp.Left);

                    if (temp.Right != null)
                        queue.Enqueue(temp.Right);
                }
                return CountChild;
            }
            return 0;
        }

        public void BranchComprarison()
        {
            if (_head != null)
            {
                Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();

                queue.Enqueue(_head);

                while (queue.Count != 0)
                {
                    BinaryTreeNode<T> temp = queue.Dequeue();

                    if (temp.LeftHeight != temp.RightHeight) Console.Write(temp.Value + " ");

                    if (temp.Left != null)
                        queue.Enqueue(temp.Left);

                    if (temp.Right != null)
                        queue.Enqueue(temp.Right);
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
