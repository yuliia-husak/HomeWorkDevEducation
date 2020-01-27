using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_002_Classes_Consstructors.MultiHouse;
using _02_002_Classes_Consstructors._02_Task_Reservoir;
using _02_002_Classes_Consstructors._04_Task_Fraction;
using _02_002_Classes_Consstructors._05_Task_PhoneBook;

namespace _02_002_Classes_Consstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            #region House
            //Human human = new Human();
            //Human human1 = new Human("Ivan", "Ivanov", 18);
            //Human human2 = new Human("Ivan", "Ivanov", 19);
            //Human human3 = new Human("Ivan", "Ivanov", 20);
            //Human human4 = new Human("Ivan", "Ivanov", 21);
            //Human human5 = new Human("Ivan", "Ivanov", 22);
            //Human human6 = new Human("Ivan", "Ivanov", 23);

            //human.Show();
            //human1.Show();

            //Apartment apartment1 = new Apartment(1, 1);
            //Apartment apartment2 = new Apartment(2, 2);
            //Apartment apartment3 = new Apartment(3, 3);

            //House house = new House(258);
            //house.Show();
            //apartment1.Add(human1);
            //apartment2.Add(human2);
            //apartment2.Add(human3);
            //apartment3.Add(human4);
            //apartment3.Add(human5);
            //apartment3.Add(human6);

            //Console.WriteLine();
            //apartment3.Show();

            //PaymentsCommunal communal = new PaymentsCommunal();
            //communal.PayGas(apartment1);
            //communal.PayRent(apartment1);
            //communal.YourPay(apartment1);
            #endregion

            #region Reservoir---------------

            Reservoir reservoir1 = new Reservoir();
            Reservoir reservoir2 = new Reservoir("море", 2, 4, 3);
            Reservoir reservoir3 = new Reservoir();

            //Reservoir[] reservoirs = new Reservoir[3];

            List<Reservoir> reservoirs1 = new List<Reservoir>(3);
            reservoirs1.Add(new Reservoir("море", 2, 5, 3));

            for (int i = 1; i < 10; i++)
            {
                reservoirs1.Add(new Reservoir());
            }

            foreach (Reservoir p in reservoirs1)
            {
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine($"Number of ponds in array: {reservoirs1.Count}");
            reservoir2.Show();

            Console.WriteLine($"Area pound 1: {reservoirs1[0].Area()}");
            Console.WriteLine($"Volume pound 1: {reservoirs1[0].Volume()}");

            Console.WriteLine("Compare pound 1 and pound 2:");
            Console.WriteLine("pound 1: " + reservoirs1[0].ToString());
            Console.WriteLine("pound 2: " + reservoirs1[1].ToString());
            if (reservoir1.CompareAreaMore(reservoirs1[0], reservoirs1[1]))
                Console.WriteLine("pound 1 > pound 2");
            else
                Console.WriteLine("pound 1 < pound 2");
            #endregion

            #region Fraction

            //Fraction fraction = new Fraction();
            //Fraction fraction1 = new Fraction();
            //Fraction test=new Fraction();

            //test=Fraction.Sum(fraction, fraction1);




            #endregion
            Console.ReadKey();
        }
    }
}
