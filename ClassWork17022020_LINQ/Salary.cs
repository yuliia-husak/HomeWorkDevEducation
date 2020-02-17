using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork17022020_LINQ
{
    
    class Salary
    {        
        public string code { get; set; }
        public float salary1 { get; set; }
        public float salary2 { get; set; }

        // чтение данных из файла "Salary.txt"
        public void Read_Salary()
        {
            List<Salary> ls = null;
            // создать объект класса StreamReader, соответствующий файлу "Salary.txt"
            StreamReader sr = File.OpenText("Salary.txt");
            string[] fields; // переменная, соответствующая полям структуры Workers
            string line = null;
            Salary s=new Salary();

            // прочитать строку
            line = sr.ReadLine();

            while (line != null)
            {                
                // разбить строку на подстроки - разделителем есть символ ';'
                fields = line.Split(';');
               
                // создание структуры типа Salary                
                s.code = fields[0];
                s.salary1 = (float)Convert.ToDouble(fields[1]);
                s.salary2 = (float)Double.Parse(fields[2]);

                // добавление структуры типа Salary в список List<Salary>
                ls.Add(s);
                
                // прочитать следующую строку
                line = sr.ReadLine();
            }
        }
    }
}
