using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_001_Classes
{
    class MyData
    {
        //Поле
        DateTime date;

        //Конструкторы, позволяющие установить:
        //заданную дату
        public MyData(DateTime yymmdd)
        {
            date = yymmdd;
        }
        //дату 1.01.2009
        public MyData()
        {
            date = new DateTime(2009, 01, 01);
        }

        //Методы, позволяющие:
        //вычислить дату предыдущего дня;
        public DateTime PreviousDay()
        {
            return date.AddDays(-1);
        }

        //вычислить дату следующего дня;
        public DateTime NextDay()
        {
            return date.AddDays(1);
        }

        //определить сколько дней осталось до конца месяца.
        public int HowDaysEndMonth()
        {
            int dayMonth = DateTime.DaysInMonth(date.Year, date.Month);
            int numberDays = 0;
            for (int i = date.Day; i < dayMonth; ++i)
            {
                numberDays += 1;
            }

            return numberDays;
        }

        //Свойства:
        //позволяющее установить или получить значение поле класса(доступно для чтения и записи)
        public DateTime GetSetDate
        {
            get { return date; }
            set { date = value; }
        }

        //позволяющее определить год высокосным(доступно только для чтения)
        public bool Year
        {
            get
            {
                int numDays = DateTime.DaysInMonth(date.Year, 2);
                if (numDays == 29) return true;
                else return false;
            }
        }

    }
}
