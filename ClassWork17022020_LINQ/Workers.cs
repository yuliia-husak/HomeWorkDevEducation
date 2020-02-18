using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork17022020_LINQ
{
    class Workers
    {        
        public int code { get; set; }
        public string name { get; set; }
        public string education { get; set; }
        public string profession { get; set; }

        public int year { get; set; }
        
        public static List<Workers> Read_Workers()
        {          
            List<Workers> workers = new List<Workers>();
            string path = @"C:\Users\user\Source\Repos\HomeWorkDevEducation4\ClassWork17022020_LINQ\Worker.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                string[] text;
                while (!sr.EndOfStream)
                {
                    text = sr.ReadLine().Split(';');
                    Workers tmp = new Workers();
                    tmp.code = int.Parse(text[0]);
                    tmp.name = text[1];
                    tmp.education = text[2];
                    tmp.profession = text[3];
                    tmp.year = int.Parse(text[4]);
                    workers.Add(tmp);
                }
            }
            return workers;
        }
    }
}
