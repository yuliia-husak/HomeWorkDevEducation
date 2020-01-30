using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

namespace _02_007_HomeTask_Struct
{
    public static class Program
    {
        private static void Main()
        {

            string[] inputData = File.ReadAllLines("TextInput.txt");
            Student[] students = new Student[inputData.Length];
            for (int index = 0; index < inputData.Length; index++)
            {
                string line = inputData[index];
                string[] fiends = line.Split(',');
                Student student = new Student(fiends[0], fiends[1],
                        Convert.ToInt32(fiends[2]), fiends[3], Convert.ToInt32(fiends[4]),
                        Convert.ToInt32(fiends[5]), Convert.ToInt32(fiends[6]),
                        Convert.ToInt32(fiends[7]), Convert.ToInt32(fiends[8]));
                students[index] = student;
            }
            Console.WriteLine("Исходные данные.");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine("-----------------------------------");
            }
            Array.Sort(students);
            Console.WriteLine("Отсортированные данные.");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine("-----------------------------------");
            }

            //записываем в файл отсортированный массив студентов по фамилии
            string[] linesToSave = new string[students.Length];
            for (int i = 0; i < students.Length; i++)
            {
                Student student = students[i];
                linesToSave[i] = student.ToString();
            }

            File.WriteAllLines("output.txt", linesToSave);

            //string[] inputData = File.ReadAllLines("TextInput.txt");
            IEnumerable<Student> dataQueue = from str in inputData
                                             let subs = str.Split(new[] { ',' })
                                             select new Student
                                             {
                                                 Name = subs[0],
                                                 Faculty = subs[1],
                                                 Course = Convert.ToInt32(subs[2]),
                                                 Group = subs[3],
                                                 Assessments1 = Convert.ToInt32(subs[4]),
                                                 Assessments2 = Convert.ToInt32(subs[5]),
                                                 Assessments3 = Convert.ToInt32(subs[6]),
                                                 Assessments4 = Convert.ToInt32(subs[7]),
                                                 Assessments5 = Convert.ToInt32(subs[8])
                                             };

            Console.WriteLine("- вывести в новый файл информацию о тех студентах, которые имеют хотя бы одну двойку, отсортировав их по курсу.\nВведите оценку - 2");
            int minAsses = Convert.ToInt32(Console.ReadLine());
            IOrderedEnumerable<Student> outputData = from data in students
                                                     where data.Assessments1 == minAsses ||
                                                     data.Assessments2 == minAsses ||
                                                     data.Assessments3 == minAsses ||
                                                     data.Assessments4 == minAsses ||
                                                     data.Assessments5 == minAsses
                                                     orderby data.Course
                                                     select data;
            Console.WriteLine();
            Console.WriteLine("Отфильтрованные данные по группе с оценкой 2: ");
            foreach (Student s in outputData)
            {
                Console.WriteLine(s);
                Console.WriteLine("-----------------------------------");
            }
            File.WriteAllLines("TextOutput2.txt",
                               outputData.Select(at =>
                                                 at.Name + ", " +
                                                 at.Faculty + ", " +
                                                 at.Course + ", " +
                                                 at.Group + ", " +
                                                 at.Assessments1 + ", " +
                                                 at.Assessments2 + ", " +
                                                 at.Assessments3 + ", " +
                                                 at.Assessments4 + ", " +
                                                 at.Assessments5));

            //сериализация
            Student student1 = new Student("Sepon I.B.", "PO", 2, "PSD", 1, 2, 3, 4, 5);
            string ser = JsonConvert.SerializeObject(student1); // Эту строку можно сохранить в файле
            //Console.WriteLine(ser);

            Student[] stud = new Student[2];
            stud[0] = student1;
            stud[1] = new Student("Grinpan T.N.", "PO", 2, "PSD", 1, 2, 3, 4, 5);

            string convertarray = JsonConvert.SerializeObject(stud);
            //Console.WriteLine(convertarray);

            //десериальзация массива
            Student[] stud2 = JsonConvert.DeserializeObject<Student[]>(convertarray);

            Console.WriteLine("Вывод новых студентов: ");
            foreach (Student st in stud2)
            {
                Console.WriteLine(st.ToString());                
            }
            

            //записываем в файл новых студентов
            string[] linesToSave2 = new string[stud2.Length];
            for (int i = 0; i < stud2.Length; i++)
            {
                Student student = stud2[i];
                linesToSave2[i] = student.ToString();
            }
            
            File.AppendAllLines("TextInput.txt", linesToSave2);

            // оценка 4 и 5
            Console.WriteLine("- вывод на дисплей фамилий и номеров групп для всех студентов, имеющих оценки 4 и 5;\n" +
                " если таких студентов нет, вывести соответствующее сообщение.");
            int four = 4;
            int five = 5;            
            IOrderedEnumerable<Student> outputData4and5 = from data in students
                                                     where (data.Assessments1 == four ||
                                                     data.Assessments2 == four ||
                                                     data.Assessments3 == four ||
                                                     data.Assessments4 == four ||
                                                     data.Assessments5 == four) &&
                                                     (data.Assessments1==five||
                                                     data.Assessments2 == five ||
                                                     data.Assessments3 == five ||
                                                     data.Assessments4 == five ||
                                                     data.Assessments5 == five)
                                                          orderby data.Course
                                                     select data;
            Console.WriteLine();
            Console.WriteLine("Данные по ударникам: ");
            foreach (Student s in outputData4and5)
            {
                //if (outputData4and5.Count < 0) Console.WriteLine("Таких студентов нет!");
                Console.WriteLine(s.Name + s.Group);
                Console.WriteLine("-----------------------------------");
            }

            Student[] studKey = new Student[2];
            for(int i = 0; i < studKey.Length; i++)
            {
                Console.WriteLine("Written name: ");
                studKey[i].Name = Console.ReadLine();
                Console.WriteLine("Written faculty: ");
                studKey[i].Faculty = Console.ReadLine();
                Console.WriteLine("Written course: ");
                studKey[i].Course = int.Parse(Console.ReadLine());
                Console.WriteLine("Written group: ");
                studKey[i].Group = Console.ReadLine();
                Console.WriteLine("Written ozenki: ");
                studKey[i].Assessments1 = int.Parse(Console.ReadLine()); 
                Console.WriteLine("Written ozenki: ");
                studKey[i].Assessments2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Written ozenki: ");
                studKey[i].Assessments3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Written ozenki: ");
                studKey[i].Assessments4 = int.Parse(Console.ReadLine());
                Console.WriteLine("Written ozenki: ");
                studKey[i].Assessments5 = int.Parse(Console.ReadLine());
            }

            // cортировка по среднему балу
            Console.WriteLine("- cортировка по среднему балу");  
            IOrderedEnumerable<Student> outputDataSrBall = from data in studKey
                                                          
                                                          //data.Assessments1 +=
                                                          //data.Assessments2 +=
                                                          //data.Assessments3 == four ||
                                                          //data.Assessments4 == four ||
                                                          //data.Assessments5 == four
                                                          orderby data.Course
                                                          select data;
            Console.WriteLine();
            Console.WriteLine("Данные по ударникам: ");
            foreach (Student s in outputData4and5)
            {
                //if (outputData4and5.Count < 0) Console.WriteLine("Таких студентов нет!");
                Console.WriteLine(s.Name + s.Group);
                Console.WriteLine("-----------------------------------");
            }
            Console.ReadKey();
        }
    }

    internal struct Student : IComparable
    {
        int[] ozenki;
        public Student(string name, string faculty, int course, string group,
            int assessments1, int assessments2, int assessments3, int assessments4, int assessments5) : this()
        {
            Name = name;
            Faculty = faculty;
            Course = course;
            Group = group;
            Assessments1 = assessments1;
            Assessments2 = assessments2;
            Assessments3 = assessments3;
            Assessments4 = assessments4;
            Assessments5 = assessments5;
        }

        public string Name { get; set; }

        public string Faculty { get; set; }

        public int Course { get; set; }

        public string Group { get; set; }

        public int[] Ozenki { get; set; }
        public int Assessments1 { get; set; }

        public int Assessments2 { get; set; }

        public int Assessments3 { get; set; }

        public int Assessments4 { get; set; }

        public int Assessments5 { get; set; }

        #region IComparable Members
        public int CompareTo(object obj)
        {
            return Name.CompareTo(((Student)obj).Name);
        }
        #endregion
        public override string ToString()
        {
            return string.Format("{0}; {1}; {2}; {3}; {4}; {5}; {6}; {7}; {8}.",
                Name, Faculty, Course, Group, Assessments1,
                Assessments2, Assessments3, Assessments4, Assessments5);
        }
    }
}

