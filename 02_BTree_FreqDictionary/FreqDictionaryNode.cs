using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BTree_FreqDictionary
{
    class FreqDictionaryNode
    {
        public FreqDictionaryNode(string key) { Key = key; }

        public FreqDictionaryNode Left { get; set; }

        public FreqDictionaryNode Right { get; set; }

        public int Count { get; set; } = 1;

        public string Key
        {
            get;
            private set;
        }
       
    }
}
