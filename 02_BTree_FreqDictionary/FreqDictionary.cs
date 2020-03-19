using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BTree_FreqDictionary
{
    public class FreqDictionary
    {
        private FreqDictionaryNode _head;        

        #region Добавление нового узла дерева

        void Insert (string key)
        {
            // Первый случай: дерево пустое     

            if (_head == null)
            {
                _head = new FreqDictionaryNode(key);
                //_head.Left = _head.Right = null;
                _head.Count = 1;
                
            }

            // Второй случай: дерево не пустое, поэтому применяем рекурсивный алгорит 
            //                для поиска места добавления узла        

            else
            {
                InsertTo(_head, key);

                //int rez = String.Compare(node.Key, key);
                //if (rez == 0)
                //{
                //    node.Count++;
                //    return 0;
                //}
                //else
                //    if (rez > 0)
                //    return Insert(node.Left, key);
                //else return Insert(node.Right, key);
                
            }            
        }

        private void  InsertTo(FreqDictionaryNode node, string key)
        {
            if(String.Compare(node.Key, key) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new FreqDictionaryNode(key);
                }
                else
                {
                    InsertTo(node.Left, key);
                }
            }
            else  if(String.Compare(node.Key, key) > 0)
            {
                if (node.Right == null)
                {
                    node.Right = new FreqDictionaryNode(key);
                }
                else
                {
                    InsertTo(node.Right, key);
                }
            }
            else if(String.Compare(node.Key, key) == 0)
            {
                node.Count++;
            }
        }
        #endregion

        #region Вывод на экран в лексикографическом порядке
        void Show(FreqDictionaryNode node)
        {
            if (node != null)
            {
                Show(node.Right);
                Console.WriteLine("{0,-3} - {1}",node.Key,node.Count);
                Show(node.Left);
            }
        }
        #endregion

        #region Построение дерева поиска
        int CreateSearchTree(string str)
        {
            StreamReader f = new StreamReader(str);
            string s = f.ReadToEnd();
            
            string[] words = s.Split(',', '.', ' ', '!', ':', '?');
           
            for(int i = 0; i < words.Length; i++)
            {
                
                Insert(words[i]);
            }
            f.Close();

            return 0;
        }

        #endregion

        public void Start()
        {
            //FreqDictionaryNode head;
            CreateSearchTree("text.txt");
            Show(_head);
        }

    }
}
