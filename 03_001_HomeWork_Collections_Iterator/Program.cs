using _03_001_HomeWork_Collections_Iterator.Task_5_NameMonth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _03_001_HomeWork_Collections_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 01 Iterator
            Aggregate a = new ConcreteAggregate();
            a[0] = "Element A";
            a[1] = "Element B";
            a[2] = "Element C";
            a[3] = "Element D";

            Iterator i = a.CreateIterator();
            for (object e = i.First(); !i.IsDone(); e = i.Next()) Console.WriteLine(e);


            //Task 02 UserColection
            NameCollection nameCollection = new NameCollection();
            foreach (string s in nameCollection)
            {
                Console.Write(" " + s);
            }


            //Task 03 IColection
            Collection col1 = new Collection();
            Console.WriteLine("Count: " + col1.Count);

            foreach (var item in col1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 20));

            MyCollection<int> col2 = new MyCollection<int>() { 1, 2, 3 };

            col2.Add(4);
            col2.Add(5);

            col2.Remove(4);

            foreach (var item in col2)
            {
                Console.WriteLine(item);
            }

            //Task 04 IList
            var test = new AList();

            // Populate the List.
            Console.WriteLine("Populate the List");
            test.Add("one");
            test.Add("two");
            test.Add("three");
            test.Add("four");
            test.Add("five");
            test.Add("six");
            test.Add("seven");
            test.Add("eight");
            test.Show();
            Console.WriteLine();

            // Remove elements from the list.
            Console.WriteLine("Remove elements from the list");
            test.Remove("six");
            test.Remove("eight");
            test.Show();
            Console.WriteLine();

            // Add an element to the end of the list.
            Console.WriteLine("Add an element to the end of the list");
            test.Add("nine");
            test.Show();
            Console.WriteLine();

            // Insert an element into the middle of the list.
            Console.WriteLine("Insert an element into the middle of the list");
            test.Insert(4, "number");
            test.Show();
            Console.WriteLine();

            // Check for specific elements in the list.
            Console.WriteLine("Check for specific elements in the list");
            Console.WriteLine($"List contains \"three\": {test.Contains("three")}");
            Console.WriteLine($"List contains \"ten\": {test.Contains("ten")}");
            Console.WriteLine(new string('-', 25));

            //*******************Task 5: Months*****************           

            var month = new CollectionMonth<Element>();

            month[0] = new Element(1, "January", 31);
            month[1] = new Element(2, "February", 29);
            month[2] = new Element(3, "March", 31);
            month[3] = new Element(4, "April", 30);
            month[4] = new Element(5, "May", 31);
            month[5] = new Element(6, "June", 30);
            month[6] = new Element(7, "July", 31);
            month[7] = new Element(8, "August", 31);
            month[8] = new Element(9, "September", 30);
            month[9] = new Element(10, "October", 31);
            month[10] = new Element(11, "November", 30);
            month[11] = new Element(12, "December", 31);

            Console.WriteLine("All collection: ");
            // В циклической конструкции foreach выводим содержимое коллекции на экран.
            foreach (Element element in month)
            {
                Console.WriteLine("{0}, {1}, {2}",
                    element.Id,
                    element.Name,
                    element.AmountDay);
            }

            Console.Write("Enter number month: ");
            int x = int.Parse(Console.ReadLine());
            foreach (Element element in month)
            {
                if (element.Id == x)
                {
                    Console.WriteLine("This month {0}",                    
                    element.Name);
                }
                
            }

            Console.Write("Enter amount days of month: ");
            int y = int.Parse(Console.ReadLine());
            foreach (Element element in month)
            {
                if (element.AmountDay == y)
                {
                    Console.WriteLine("This month {0}",
                    element.Name);
                }

            }
            Console.WriteLine(new string('-', 5));
            int actual = 0;
            foreach (Element element in month)
            {
                actual++;
            }

            Console.WriteLine(actual);


            Console.ReadLine();
        }
    }
}
