using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_002_Classes_Consstructors.MultiHouse
{
    class House
    {
        public Apartment[] apartments = new Apartment[0];

        int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        
        public House()
        {
            number = 0;
        }

        public House(int n)
        {
            this.number = n;
        }

        public void Add(Apartment item)
        {
            var newArray = new Apartment[apartments.Length + 1];
            apartments.CopyTo(newArray, 0);
            newArray[newArray.Length - 1] = item;
            apartments = newArray;
        }

        public void Clear()
        {
            apartments = new Apartment[0];
        }

        public bool Contains(Apartment item)
        {
            foreach (var element in apartments)
            {
                if (element.Equals(item))
                    return true;
            }

            return false;

            ////Or we can use LINQ :)

            return apartments.Contains(item);
        }

        public void CopyTo(Apartment[] array, int arrayIndex)
        {
            apartments.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return apartments.Length; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(Apartment item)
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            Console.WriteLine($"House number: {number}\n Counts apartments:{apartments.Length}");            
        }

    }
}
