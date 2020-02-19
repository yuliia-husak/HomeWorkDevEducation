using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public override string ToString()
        {
            return $"Surname: {LastName}," +
                $"Name: {FirstName}," +
                $"Birhday: {Birthday}";
        }
       
    }
}
