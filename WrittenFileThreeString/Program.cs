using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenFileThreeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            try
            {
                StreamReader f = new StreamReader("outputtext.txt");

                ///Написать программу, которая считывает из текстового файла три предложения 
                ///и выводит их в обратном порядке.    
                string s = f.ReadToEnd();
                char[] charToTrim = { ' ' };
                s = s.Trim(charToTrim);
                
                string[] words = s.Split(new char[] { '.' });              

                Console.WriteLine($"Sourse text read from file \"outputtext.txt\": \n{s}");
                Array.Reverse(words);
                

                foreach(string str in words)
                {
                    Console.WriteLine("*" + str);
                }
                f.Close();
                //--------------------------norm method-----------------------------
                System.IO.StreamReader f2 = new System.IO.StreamReader(@"C:\Users\user\Source\Repos\HomeWorkDevEducation2\WrittenFileThreeString\bin\Debug\outputtext.txt", Encoding.GetEncoding("windows-1251"));
                string n = "", n2 = "";
                string[] vs=new string[3];
                int count = 0;
                while (((n = f2.ReadLine()) != null) && count < 3)
                {
                    char[] ch = n.ToCharArray();
                    foreach (char c in ch)
                    {
                        if (c != '.' && c != '!' && c != '?')
                            n2 += c;
                        else
                        {
                           
                            if (count >= 3)
                                break;
                            vs[count] = n2;
                            n2 = "";
                            ++count;  
                        }
                    }
                }
                ReverseString(vs);


               ///Написать программу, которая считывает текст из файла и выводит 
               ///на экран только предложения, содержащие введенное с клавиатуры слово.
               ///
                Console.Write("Written word: ");
                string wword = (Console.ReadLine());
                Console.WriteLine($"Your word: {wword}");
                string str2 = "";
                int sizeCh2 = 0;

                for(int i = 0; i < words.Length; i++)
                {
                    char[] ch2 = words[i].ToCharArray();
                    sizeCh2 = ch2.Length - 1;
                    foreach (char c in ch2)
                    {

                        if (c != '.' && c != '!' && c != '?' && c != ' ' && c != ',')
                        {
                            str2 += c;
                            if (str2 == wword) 
                            {
                                Console.WriteLine($"Your word {wword} foung in string: \n{words[i]}");
                                i = words.Length;
                                str2 = "";
                                break;
                            };
                        }
                            
                        else 
                        {
                            if (str2 == wword)
                            {
                                Console.WriteLine($"Your word {wword} foung in string: \n{words[i]}");
                                i = words.Length;
                                str2 = "";
                                break;
                            }  
                            str2 = "";                           
                        }
                       
                    }
                    if (i == words.Length - 1) Console.WriteLine($"Your wors {wword} not found!!!");
                }
                f.Close();
                ///Написать программу, которая считывает текст из файла и выводит на экран только строки, содержащие двузначные числа. 
                ///
                StreamReader reader = new StreamReader("outputtext.txt");
                string a = reader.ReadLine();
                
                string[] aString = a.Split('.', '!', '?');
                string temp = "";
                int countDigit = 0;
                for(int i = 0; i < aString.Length; i++)
                {
                    string[] vs1 = aString[i].Split(' ',',',':');
                    for (int j = 0; j < vs1.Length; j++)
                    {
                        temp = vs1[j];
                        if (temp.Length == 2)
                        {
                            for(int z = 0; z < 1; z++)
                            {
                                char[] ch3 = vs1[j].ToCharArray();
                                foreach (char c2 in ch3)
                                {
                                    if (Char.IsDigit(c2)) countDigit++;
                                    if (countDigit==2)
                                    {
                                        Console.WriteLine($"Your digit {temp} foung in string: \n{aString[i]}");
                                        countDigit = 0;
                                    }
                                }                                
                            }  
                        }
                    }
                }
                f.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Проверьте правильность имени файла!");
                Console.Read();
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return;
            }

            Console.ReadLine();
        }

        //Метод для вывода слов в предложении в обратном порядке
        static void ReverseWords(string s, int i)
        {
            Console.WriteLine("\n\n =========Предложение № {0}=========== \n {1}", i, s);
            Console.WriteLine("  ==========В обратном порядке слов==========");
            string[] split = s.Split();
            for (int j = split.Length - 1; j > 0; --j)
                Console.Write(split[j] + " ");
        }


        //Метод для вывода массива строк в обратном порядке
        static void ReverseString(string[] mas)
        {
            Console.WriteLine("\n\n ========={0} предложения в обратном порядке =========== \n ", mas.Length);     
            for (int j = mas.Length - 1; j >= 0; --j)
                Console.WriteLine(mas[j] + " ");
        }
    }
}
