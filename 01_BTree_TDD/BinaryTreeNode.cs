using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BTree_TDD
{
    class BinaryTreeNode<TNode> : IComparable<TNode> where TNode : IComparable<TNode>
    {
        public BinaryTreeNode(TNode value) { Value = value; }

        public BinaryTreeNode<TNode> Left { get; set; }

        public BinaryTreeNode<TNode> Right { get; set; }

        public TNode Value
        {
            get;
            private set;
        }
        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }        

        private int MaxChildHeight(BinaryTreeNode<TNode> node)
        {
            if (node != null)
            {
                return 1 + Math.Max(MaxChildHeight(node.Left), MaxChildHeight(node.Right));
            }
            return 0;
        }

        internal int RightHeight
        {
            get
            {
                return MaxChildHeight(Right);
            }
        }

        internal int LeftHeight
        {
            get
            {
                return MaxChildHeight(Left);
            }
        }
    }
       
    
}
