using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _003_xml
{
    class Program
    {       
        static void Main(string[] args)
        {
            var groups = new List<Group>();
            var students = new List<Student>();

            for (int i = 1; i < 10; i++)
            {
                //инициализируем приватную переменную после создания не в конструкторе
                var group = new Group(i, "Группа " + i);
                group.SetPrivet(i);
                groups.Add(group);
            }

            for (int i = 0; i < 300; i++)
            {
                var studen = new Student(Guid.NewGuid().ToString().Substring(0, 5), i % 100)
                {
                    Group = groups[i % 9]
                };

                students.Add(studen);
            }
            
            //отличие нужно указать в каком формате будет сериализовать список
            var xmlFormatter = new XmlSerializer(typeof(List<Group>));
            
            using (var file = new FileStream("groups.xml", FileMode.OpenOrCreate))
            {
                xmlFormatter.Serialize(file, groups);
            }
            using (var file = new FileStream("groups.xml", FileMode.OpenOrCreate))
            {
                var newGroups = xmlFormatter.Deserialize(file) as List<Group>;

                if (newGroups != null)
                {
                    foreach (var group in newGroups)
                    {
                        Console.WriteLine(group);
                    }
                }
            }

            Console.ReadLine();

        }

    }
}

