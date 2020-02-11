using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Delegate
{
  
    class Program
    {       

        static void Main(string[] args)
        {
            StrMod ReplaceSpaces = null;
            //Сконструировать делегат
            StrMod strOp = new StrMod(ReplaceSpaces);
        }
    }
}
