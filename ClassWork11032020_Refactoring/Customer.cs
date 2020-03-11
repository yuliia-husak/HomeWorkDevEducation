using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork11032020_Refactoring
{
    class Customer
    {
        // Поля
        private string name = null;
        private List<Rental> rentals = new List<Rental>();

        // Методы
        public Customer(string name)
        {
            this.name = name;
        }

        //  TODO: Метод Statement() - слишком громоздкий.
        /// <summary>
        /// Метод создающий отчет.
        /// </summary>
        /// <returns></returns>
        public string Statement()
        {
            //// Сначала мы объявляем какие-то локальные переменные.
            //double totalAmount = 0;
            //int frequentRenterPoints = 0;
            string result = string.Format("Учет аренды для {0}: ", name);

            // Затем для каждого клиента мы рассчитываем задолженность...
            foreach (Rental rental in rentals)
            {                
                result += "\t" + rental.Movie.Title + "\t" + rental.GetCharge() + "\n";
            }

            // Добавить нижний колонтитул 
            result += "Сумма задолженности составляет " + GetTotalCharge() + "\n";
            result += "Вы заработали " + GetTotalFrequentRenterPoints() + " очков за активность";
            return result;
        }

        public string HtmlStatement()
        {
            string result = "<H1>Операции аренды для <EM>" + Name + "</EM></H1><P>\n";
            foreach (Rental rental in rentals)
            {
                result += rental.Movie.Title + rental.GetCharge() + "<BR>\n";
            }

            // Добавить нижний колонтитул 
            result += "<P>Сумма задолженности составляет " + GetTotalCharge() + "</EM><P>\n";
            result += "Вы заработали <EM>" + GetTotalFrequentRenterPoints() + "<EM> очков за активность<P>";

            return result;
        }
        private double GetTotalCharge()
        {
            double result = 0;
            foreach(Rental rental in rentals)
            {
                result += rental.GetCharge();
            }
            return result;
        }

        private int GetTotalFrequentRenterPoints()
        {
            int result = 0;
            foreach (Rental rental in rentals)
            {
                result += rental.GetFrequentRenterPoints();
            }
            return result;

        }
        // Свойства
        public Rental Rentals
        {
            set { this.rentals.Add(value); }
        }

        public string Name
        {
            get { return this.name; }
        }
    }
}
