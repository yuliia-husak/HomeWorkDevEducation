using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _001_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            var groups = new List<Group>();
            var students = new List<Student>();

            for(int i = 1; i < 10; i++)
            {
                //инициализируем приватную переменную после создания не в конструкторе
                var group = new Group(i, "Группа " + i);
                group.SetPrivet(i);
                groups.Add(group);
            }

            for(int i = 0; i < 300; i++)
            {
                var studen = new Student(Guid.NewGuid().ToString().Substring(0, 5), i % 100)
                {
                    Group = groups[i % 9]
                };

                students.Add(studen);
            }

            var binFormatter = new BinaryFormatter();

            using (var file = new FileStream("groups.bin", FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(file, groups);
            }
            using (var file = new FileStream("groups.bin", FileMode.OpenOrCreate))
            {
                var newGroups = binFormatter.Deserialize(file) as List<Group>;

                if (newGroups != null)
                {
                    foreach(var group in newGroups)
                    {
                        Console.WriteLine(group);
                    }
                }
            }
            Console.ReadLine();
        }




    }
}
