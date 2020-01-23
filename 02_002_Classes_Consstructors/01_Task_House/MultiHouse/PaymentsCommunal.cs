using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_002_Classes_Consstructors.MultiHouse
{
    public class PaymentsCommunal
    {        
        double rent=1.25;
        double gas=6.35;
        double wouter=12.50;
        double electricity=2.50;

        double allpay = 0.0;

        public double Rent => rent;
        public double Gas => gas;
        public double Wouter => wouter;
        public double Electricity => electricity;


        //x-кол-во комнат, y-кол-во людей
        public double PayRent( Apartment apartment)
        {
            int x = apartment.Countrooms;
            int y = apartment.people.Length;
            
            allpay += x * rent * y;
            return allpay;
        }

        public double PayGas(Apartment apartment)
        {
            int x = apartment.Countrooms;
            int y = apartment.people.Length;
            allpay += y * gas;
            return allpay;
        }

        public double PayWouter(Apartment apartment)
        {
            int x = apartment.Countrooms;
            int y = apartment.people.Length;
            allpay += y * wouter;
            return allpay;
        }

        public double PayElectricity(Apartment apartment)
        {
            int x = apartment.Countrooms;
            int y = apartment.people.Length;
            allpay += x * electricity * y;
            return allpay;
        }

        public double YourPay(Apartment apartment)
        {
            PayRent(apartment);
            Console.WriteLine($"Your pay:{allpay}");
            return  allpay;
        }

        public void Show()
        {
            Console.WriteLine($"Your pay:{allpay}");
        }
    }

    
}
