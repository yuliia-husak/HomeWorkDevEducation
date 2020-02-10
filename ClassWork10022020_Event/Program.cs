using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork10022020_Event
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> group = new List<Student>
            {
                new Student
                {
                    FirstName="John",
                    LastName="Miller",
                   
                },

                new Student
                {
                    FirstName="Olenf",
                    LastName="Kostiuk",
                    
                }
            };

            Teacher teacher = new Teacher();
            foreach(Student item in group)
            {
                teacher.examEvent += item.Exam;
            }

            teacher.Exam("Task");

            Console.ReadLine();
        }
    }
}
