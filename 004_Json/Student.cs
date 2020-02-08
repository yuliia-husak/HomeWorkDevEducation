using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _004_Json
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Age { get; set; }

        
        public Group Group { get; set; }
        public Student(string name, int age)
        {
            //проверка входных параметров
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
