using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Soap
{
    [Serializable]
    public class Group
    {
        [NonSerialized]//не хотим сериализовать рандом
        private static Random rnd = new Random(DateTime.Now.Millisecond);

        private int privateint;
        public int Number { get; set; }
        public string Name { get; set; }

        public Group()
        {
            Number = rnd.Next(1, 10);
            Name = "Группа " + rnd;
            
        }
        public Group(int number, string name)
        {
            //проверка входных данных
            Number = number;
            Name = name;
            
        }
        public void SetPrivet(int i)
        {
            privateint = i;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
