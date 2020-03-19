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
            int doublenumber = 0;

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
                    // Искомый элемент найден и ищем дальше            

                }
            }
            return doublenumber;
        }

        //проверка является ли дерево симметричным
        internal bool TreeSymetrical()
        {
            if (_head != null)
            {
                Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();

                queue.Enqueue(_head);

                while (queue.Count != 0)
                {
                    BinaryTreeNode<T> temp = queue.Dequeue();

                    if ((temp.LeftHeight - temp.RightHeight) > 1 || (temp.LeftHeight - temp.RightHeight) < -1)
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

        //высота дерева
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
        public int SumElementLevel()
        {
            BinaryTreeNode<T> node = _head;
            int maxElement = CountElement(node, 0, 3);
            //вывод на экран для информации
            Console.WriteLine("\nВысота дерева:  " + HeightTree(_head));
            return maxElement;
        }
        //--------------------------------------------

        //определение максимального и минимального элемента на к-м уровне дерева
        void InitMinMax(BinaryTreeNode<T> node, int level, int[] min, int[] max)
        {
            if (node != null)
            {
                min[level] = max[level] = Convert.ToInt32(node.Value);
                InitMinMax(node.Left, level + 1, min, max);
                InitMinMax(node.Right, level + 1, min, max);
            }
        }

        void MinMax(BinaryTreeNode<T> node, int level, ref int[] min, ref int[] max)
        {
            if (node != null)
            {
                if ((Convert.ToInt32(node.Value)) < min[level])
                    min[level] = Convert.ToInt32(node.Value);
                if ((Convert.ToInt32(node.Value)) > max[level])
                    max[level] = Convert.ToInt32(node.Value);
                MinMax(node.Left, level + 1, ref min, ref max);
                MinMax(node.Right, level + 1, ref min, ref max);
            }
        }

        public int[] FindMinMax()
        {
            BinaryTreeNode<T> node = _head;
            int[] min; int[] max;
            int h = HeightTree(_head);
            min = new int[h + 1];
            max = new int[h + 1];
            InitMinMax(node, 0, min, max);
            MinMax(node, 0, ref min, ref max);

            Console.WriteLine($"\t \nHead: \t{_head.Value}");
            for(int i = 1; i < h + 1; i++)
            {
                Console.WriteLine($"Level {i}: min = {min[i]}, max = {max[i]}");
            }

            int[] result = new int[h * 2 + 1];
            for(int i = 0; i < min.Length; i++)
            {
                result[i] = min[i];
            }
            for (int i = h+1, j = 1; i < result.Length; i++, j++)
            {
                result[i] = max[j];
            }

            return result;
        }
        //-----------------------------------------------------------------------------

        //Вывод на экран всевозможных путей, ведущих от корня к листьям бинарного дерева.       

        void ShowRoute(int[] mas, int n)
        {
            int i;
            if (n == HeightTree(_head) + 1) 
                Console.Write("Длинный путь ");
            else
                Console.Write("Короткий путь ");
            for (i = 0; i < n; i++)
            {
                Console.Write(" " + mas[i]);
            }
                
            Console.WriteLine();
        }
        void ObhodTree(BinaryTreeNode<T> node, int[] mas, int level)
        {
            if (node != null)
            {
                mas[level] = Convert.ToInt32(node.Value);  
                if (node.Left == null && node.Right == null) ShowRoute(mas, level + 1);
                else
                {
                    ObhodTree(node.Left, mas, level + 1);
                    ObhodTree(node.Right, mas, level + 1);
                }
            }
        }

        public int[] WayTree()
        {
            BinaryTreeNode<T> node = _head;
            int[] mas;
            int h = HeightTree(_head);
            mas = new int[h + 1];
            ObhodTree(node, mas, 0);
            return mas;
        }

        //------------------------
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

        public T MinValue
        {
            get
            {
                if ( _head== null)
                    throw new InvalidOperationException("Tree is empty");
                var current = _head;
                while (current.Left != null)
                    current = current.Left;
                return current.Value;
            }
        }
        public T MaxValue
        {
            get
            {
                if (_head == null)
                    throw new InvalidOperationException("Tree is empty");
                var current = _head;
                while (current.Right != null)
                    current = current.Right;
                return current.Value;
            }
        }
    }    
}
