using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork10022020_Event
{
    class Student
    {
        public string FirstName;
        public string LastName;
        
        public void Exam(string task)
        {
            Console.WriteLine($"Student {LastName} event {task}");
        }
    }
}
