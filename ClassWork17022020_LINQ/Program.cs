using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork17022020_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arrayInt = { 5, 34, 67, 12, 94, 42 };

            IEnumerable<IGrouping<int, int>> query =
                from i in arrayInt
                group i by i % 10;

            IEnumerable<IGrouping<int, int>> query2 =
                from i in arrayInt
                group i by i % 10 into res
                where res.Count() > 1
                select res;

            Console.WriteLine("Forming groups of criteria:");
            foreach (IGrouping<int, int> key in query)
            {
                Console.Write($"Key: {key.Key} \nValue:");
                foreach (int item in key)
                {
                    Console.Write($"\t{item}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Groups with the number of elements if greater than 1:");
            foreach (IGrouping<int, int> key in query2)
            {
                Console.Write($"Key: {key.Key} \nValue:");
                foreach (int item in key)
                {
                    Console.Write($"\t{item}");
                }
                Console.WriteLine();
            }

            //*******************************************************************************************


            string[] poem = {"Two roads diverged in a yellow wood,",
                                "And sorry I could not travel both",
                                "And be one traveler, long I stood",
                                "And look down one as far as I coul",
                                "To where it bent in the undergrowth;",
                                 "en took the other, as just as fair,",
                                "And having perhaps the better claim,",
                                "Because it was grassy and wanted wear;",
                                 "Though as for that the passing there",
                                  "Had worn them really about the same,"};

            IEnumerable<string> query3 =
               from i in poem
               let words = i.Split(' ', ';', ',')
               from w in words
               where w.Count() > 5
               select w;

            IEnumerable<string> query4 =
               from i in poem
               let words = i.Split(' ', ';', ',')
               from w in words
               where w == "and" || w == "And"
               select w;
            Console.WriteLine("Words, in which more than 5 characters:");
            foreach (string item in query3)
            {
                Console.Write($"\t{item}");
            }


            Console.WriteLine("Words, and or And:");
            foreach (string item in query4)
            {

                Console.Write($"\t{item}");

            }

            //***********************************************************************************

            List<Group> groups = new List<Group>
            {
                new Group{Id=1, Name="QA" },
                new Group{Id=2, Name="C#"}
            };

            List<Student> students = new List<Student>
            {
                new Student
                {
                    FirstName="John",
                    LastName="Miller",
                    GroupId=2
                },
                new Student
                {
                    FirstName="John",
                    LastName="Leman",
                    GroupId=1
                },
                new Student
                {
                    FirstName="John",
                    LastName="Nicols",
                    GroupId=1
                },
                new Student
                {
                    FirstName="John",
                    LastName="Taylor",
                    GroupId=2
                },
            };    

            IEnumerable<Student> query5 =
                from g in groups
                join st in students on g.Id equals
                st.GroupId into res
                from r in res
                select r;

            Console.WriteLine("\n\tStudent in groups:");
            foreach (Student item in query5)
            {

                Console.WriteLine($"Surname: {item.LastName}, " +
                                    $"Name: {item.FirstName}, " +
                                    $"Group: {groups.First(g=>g.Id== item.GroupId).Name}");
            }

            //*********************************************************************************
            Console.WriteLine(new string('-', 240));
            var worker = new
            {
                FirstName = "Joht",
                LastName = "Dos",
                Salary = 7456.32
            };
            Console.WriteLine($"String: {worker}");
            Console.WriteLine($"Type: {worker.GetType()}");
            Console.WriteLine($"Hash code: {worker.GetHashCode()}");

            //**********************************************************************************
            //**********************************************************************************
            Console.WriteLine(new string('-', 240));
            List<Workers> workers = new List<Workers>();
            List<Salary> salaries = new List<Salary>();

            workers = Workers.Read_Workers();
            salaries = Salary.Read_Salary();

            var names = from item in workers
                        where item.year < (2016 - 35)
                        select item.name;
            Console.WriteLine("\n\tВывести фамилии и инициалы сотрудников выше 35 лет.:");
            foreach (string s in names)
            {
                Console.WriteLine( $"Name: {s}");
            }


            Console.WriteLine(new string('-', 240));
            var all_employees = from w in workers
                                from sl in salaries
                                let avg =(int)sl.salary1 + (int)sl.salary2
                                where w.code==sl.code
                                select w.name + " - " + w.profession + " salary for year " + avg;
            Console.WriteLine("\tAll emplouyes: ");
            foreach(var item in all_employees)
            {
                Console.WriteLine(item);
            }


            var max_salary = (from ms in salaries
                              select ms.salary2).Max();

            Console.WriteLine("\n\tВывести идентификационный код сотрудника с наибольшей зарплатой за второе полугодие.");
            Console.WriteLine($"Id = {(int)max_salary}");           

            Console.WriteLine(new string('-', 240));

            var result = from w in workers
                         from sl in salaries
                         let avg = (from s in salaries
                                    select (s.salary1 + s.salary2)).Average()
                         where ((sl.salary1 + sl.salary2) < avg) && (w.code == sl.code)
                         select w.name + " - " + w.profession;

            Console.WriteLine("\n\tВывести фамилии, инициалы и вид образования тех сотрудников, зарплата которых за год ниже средней за год");
            foreach (var item in result)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine(new string('-', 240));

            Console.ReadLine();
        }
    }
}
