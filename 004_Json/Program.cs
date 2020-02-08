using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _004_Json
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

            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Student>));
            //будет постоянно перезаписывать файл Create
            using (var file = new FileStream("students.json", FileMode.Create))
            {
                jsonFormatter.WriteObject(file, students);
            }
            using (var file = new FileStream("students.json", FileMode.OpenOrCreate))
            {
                var newStudents = jsonFormatter.ReadObject(file) as List<Student>;

                if (newStudents != null)
                {
                    foreach (var student in newStudents)
                    {
                        Console.WriteLine(student);
                    }
                }
            }

            Console.ReadLine();

        }
    }
    
}
