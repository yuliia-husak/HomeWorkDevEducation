using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_001_HomeWork_Collections_Iterator.Task_5_NameMonth
{
    public class Element
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int AmountDay { get; set; }
       
        public Element(int id, string name, int amountday)
        {
            Id = id;
            Name = name;
            AmountDay = amountday;
        }       
    }
}
