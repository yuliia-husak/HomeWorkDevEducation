using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork11032020_Refactoring
{
    class Movie
    {
        // Поля
        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;
        public const int CHILDRENS = 2;

        private string title = null;
        private int priceCode = 0;

        Price price = null;

        // Методы
        public Movie(string title, int priceCode)
        {
            this.title = title;
            PriceCode = priceCode;
        }

        public double GetCharge(int daysRented)
        {
            return price.GetCharge(daysRented);           
        }

        public int GetFrequentRenterPoints(int daysRented)
        {            
            return price.GetFrequentRenterPoints(daysRented);
        }

        // Свойства
        public int PriceCode
        {
            get { return this.priceCode; }
            set 
            {
                switch (value)
                {
                    case REGULAR:
                        {
                            price = new RegularPrice();
                            break;
                        }
                    case CHILDRENS:
                        {
                            price = new ChildrensPrice();
                            break;
                        }
                    case NEW_RELEASE:
                        {
                            price = new NewReleasePrice();
                            break;
                        }
                    default:
                        throw new ArgumentException();
                }               
            }
        }

        public string Title
        {
            get { return this.title; }
        }
    }    
}
