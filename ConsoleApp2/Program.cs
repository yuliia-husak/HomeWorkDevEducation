using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
//подключать вручную references /
//add references /assemblies/found soap=checked
using System.Runtime.Serialization.Formatters.Soap;

namespace _002_Soap
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
            //не работает с List работает с массивом
            var soapFormatter = new SoapFormatter();
            using (var file = new FileStream("groups.soap", FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(file, groups.ToArray());
            }
            using (var file = new FileStream("groups.soap", FileMode.OpenOrCreate))
            {
                var newGroups = soapFormatter.Deserialize(file) as Group[];

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

