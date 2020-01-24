using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_002_Classes_Consstructors.MultiHouse;
using _02_002_Classes_Consstructors._02_Task_Reservoir;

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

            Reservoir[] reservoirs = new Reservoir[3];

            List<Reservoir> reservoirs1 = new List<Reservoir>(3);
            reservoirs1.Add(new Reservoir("море", 2, 555554, 3));

            reservoirs1.ToString();

            foreach (Reservoir p in reservoirs1)
            {
                Console.WriteLine(p.ToString());
            }

            reservoirs.ToString();
            reservoir1.ToString();
            reservoir2.Show();

            #endregion


            Console.ReadKey();
        }
    }
}
