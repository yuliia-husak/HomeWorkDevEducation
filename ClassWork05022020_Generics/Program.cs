using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassWork05022020_Generics
{
    class Program
    {
        class Unit { }
        class Ork : Unit { }

        delegate T MyDelegate<out T>();

        delegate void MyDelegate2<in T>(T a);

        //ограничения
        class MyClass1<T> where T : class
        {
            public T variable;
        }

        class MyClass2<T> where T : struct
        {
            public T variable;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Upcast Downcast
            //upcast
            Ork ork = new Ork();
            MyDelegate<Ork> delegateOrk = () => new Ork();    
            MyDelegate<Unit> delegateUnit = delegateOrk;
            Unit unit1 = delegateUnit.Invoke();
            Console.WriteLine(unit1.GetType().Name);

            //downcadt
            MyDelegate2<Unit> delegateUnit2 = (Unit unit) =>
            Console.WriteLine(unit.GetType().Name);
            MyDelegate2<Ork> delegateOrk2 = delegateUnit2; 
            delegateOrk2(new Ork());
            #endregion

            //practic обобщения
            MyClass1<string> myClass1 = new MyClass1<string>();
            //MyClass1<char> myClass1 = new MyClass1<char>(); error!!!!!!!!!!!!
            // MyClass1<int> myClass11 = new MyClass1<int>(); error!!!!!!!!!!!!

            MyClass2<int> myClass2 = new MyClass2<int>();
            //MyClass2<string> myClass21 = new MyClass2<string>(); error!!!!!!!!!!!!


            
            Dictionary<string, string> myDict =
          new Dictionary<string, string>();

            // Adding key/value pairs in myDict 
            myDict.Add("1", "C");
            myDict.Add("2", "C++");
            myDict.Add("3", "Java");
            myDict.Add("4", "Python");
            myDict.Add("5", "C#");
            myDict.Add("6", "HTML");

            // To get count of key/value pairs in myDict 
            Console.WriteLine("Total key/value pairs" +
                  " in myDict are : " + myDict.Count);

            // Displaying the key/value pairs in myDict 
            Console.WriteLine("\nThe key/value pairs" +
                               " in myDict are : ");

            foreach (KeyValuePair<string, string> kvp in myDict)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                                  kvp.Key, kvp.Value);
            }



            string s="мама мыла рамуб";

            string[] mas = s.Split(',', '.', '.', ' ');
            Dictionary<int, string> count = new Dictionary<int, string>(3);

            for (int i = 0; i < 3; i++)
            {
                count.Add(i, mas[i]);
            }
            

            foreach (KeyValuePair<int, string> keyValue in count)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            string test = "мама";

            foreach (KeyValuePair<int, string> keyValue in count)
            {
                if (keyValue.Value == test) Console.WriteLine("Такое слово есть, ключ {0}",keyValue.Key);               
            }


            Console.ReadKey();
        }
    }
}

