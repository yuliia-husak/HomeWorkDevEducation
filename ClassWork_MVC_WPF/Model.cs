using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_MVC_WPF
{
    class Model
    {
        List<string> vs = new List<string>() { "JJJJ", "jjjj", "yyyyyyyyyyy"};   
        public string SomeMethod(string s)
        {           
           var result = from w in vs
                        where w == s
                        select w;
            if (result != null)
            {
                return s + " книга есть";
            }

            return s +  " книги нет";
        }
    }
}
