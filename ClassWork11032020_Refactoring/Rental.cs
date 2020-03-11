using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork11032020_Refactoring
{
    class Rental
    {
        // Поля
        private Movie movie = null;
        private int daysRented = 0;

        // Методы
        public Rental(Movie movie, int daysRented)
        {
            this.movie = movie;
            this.daysRented = daysRented;
        }

        public double GetCharge()
        {
            return movie.GetCharge(DaysRented);
        }

        public int GetFrequentRenterPoints()
        {
            return movie.GetFrequentRenterPoints(daysRented);
        }

        // Свойства
        public Movie Movie
        {
            get { return this.movie; }
        }

        public int DaysRented
        {
            get { return this.daysRented; }
        }
    }
}
