using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_002_Classes_Consstructors.MultiHouse
{
    public class Apartment
    {
        public Human[] people = new Human[0];
        int number;
        int countrooms;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

       
        public int Countrooms
        {
            get { return countrooms; }
            set { countrooms = value; }
        }

        public Apartment()
        {
            number = 0;
            countrooms = 0;
        }       

        public Apartment(int n, int c)
        {
            this.number = n;
            this.countrooms = c;
        }


        public void Add(Human item)
        {
            var newArray = new Human[people.Length + 1];
            people.CopyTo(newArray, 0);
            newArray[newArray.Length - 1] = item;
            people = newArray;
        }

        public void Clear()
        {
            people = new Human[0];
        }

        public bool Contains(Human item)
        {
            foreach (var element in people)
            {
                if (element.Equals(item))
                    return true;
            }

            return false;

            ////Or we can use LINQ :)

            return people.Contains(item);
        }

        public void CopyTo(Human[] array, int arrayIndex)
        {
            people.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return people.Length; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(Human item)
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            Console.WriteLine($"Apartment number: {number}\nCounts rooms: {countrooms}");
        }

    }
}
