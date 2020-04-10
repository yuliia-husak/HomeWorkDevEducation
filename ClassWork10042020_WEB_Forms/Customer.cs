using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassWork10042020_WEB_Forms
{
    [Serializable]
    public class Customer
    {
        public string FirstName;
        public int ID;
        public byte Age;
        public string Email;
        public Customer(string firstname, int id, byte age, string email)
        {
            FirstName = firstname;
            ID = id;
            Age = age;
            Email = email;
        }
    }
}