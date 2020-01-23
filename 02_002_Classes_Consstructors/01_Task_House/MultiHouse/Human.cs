using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_002_Classes_Consstructors.MultiHouse
{
    public class Human
    {
        string firstname;
        string surname;
        int age;

        public string Firsname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Age it should be more 0");
                }
                else
                {
                    age = value;
                }
            }
        }

        public Human()
        {
            firstname = "not data";
            surname = "not data";
            age = 0;
        }

        public Human(string f, string s, int a)
        {
            this.firstname = f;
            this.surname = s;
            this.age = a;
        }
        public void Show()
        {
            Console.WriteLine($"Firstname: {firstname}  Surname: {surname}  Age: {age}");

        }

    }
}
