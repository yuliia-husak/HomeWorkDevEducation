using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork21022020_IList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

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
            // Delay.
            Console.ReadKey();
        }
    }
}
