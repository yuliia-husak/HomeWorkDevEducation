using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassWork28022020_AsyncAwait_ReadWrittenFile
{
    
    class Program
    {   
        //static readonly StreamWriter stream3 = File.CreateText("text1.txt");

        //static readonly StreamReader stream1 = File.OpenText("text1.txt");

        //static readonly StreamWriter stream2 = File.CreateText("text2.txt");

        //static void ReadText1()
        //{
        //    string str = stream1.ReadToEnd();
        //}

        //static void WriteText(string str)
        //{

        //    stream2.WriteLine(str);

        //}

        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //int[] strRan = new int[100];
            //for (int i = 0; i < strRan.Length; i++)
            //{
            //    strRan[i] = rnd.Next(1, 100);
            //}

            try
            {
                StreamReader f = new StreamReader("numbers.txt");
                string s;
                const int n = 20; int[] a = new int[n]; string[] buf;
                while ((s = f.ReadLine()) != null)
                {
                    buf = s.Split(' '); 
                    long sum = 0;
                    for (int i = 0; i < buf.Length; ++i)
                    { 
                        a[i] = Convert.ToInt32(buf[i]); sum += a[i]; 
                    }
                    Console.WriteLine("{0} sum; {1}", s, sum);
                } 
                f.Close();
            }
            
            catch (FileNotFoundException e)
            { 
                Console.WriteLine( e.Message );
                Console.WriteLine(" Проверьте правильность имени файла!"); 
                return; 
            }
            catch ( Exception e ) 
            { 
                Console.WriteLine("Error; " + e.Message); 
                return;
            }

            object a2 = 5;
            object b = 5;

            bool res1 = a2 == b;
            bool res2 = a2.Equals(b);

            Console.WriteLine(res1);
            Console.WriteLine(res2);

            Console.ReadKey();
        }
    }    
}



