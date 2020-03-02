using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterDecimal
{   
    class Counter
    {
        //fields
        int count;
        int maxDiapason;
        int minDiapason;

        //properties
        public int Count
        {
            get { return count; }
            private set
            {
                if (value > minDiapason && value < maxDiapason) count = value;
                else count = minDiapason;
            }
        }

       
        public int GetCount
        {
            get { return this.count; }
        }
       

        public int MaxDiapason
        {
            get { return maxDiapason; }
            set 
            {
                if (maxDiapason > minDiapason) maxDiapason = value;
                else maxDiapason = minDiapason;
            }
        }

        public int MinDiapason
        {
            get { return minDiapason; }
            set 
            {
                if (minDiapason < maxDiapason) minDiapason = value;
                else minDiapason = maxDiapason;
            }
        }

        //constructors
        public Counter()
        {
            //if (count > maxDiapason || count < minDiapason)
            //    throw new ArgumentException("Недопустимое значение счетчика");
            this.count = 1;
            this.minDiapason = 1;
            this.maxDiapason = 1;
        }

        public Counter(int count) : this()
        {           
            this.count = count;
        }

        public Counter(int count, int minDiapason, int maxDiapason)
        {           
            this.count = count;
            this.minDiapason = minDiapason;
            this.maxDiapason = maxDiapason;
        }

        //methods
        public int Rase()
        {
            if (count < maxDiapason)
                count++;
            if (count == maxDiapason) throw new ArgumentException("Count is equal to maxDiapason");
            if (count > maxDiapason) throw new ArgumentException("Count is more to maxDiapason");
            return count;
        }

        public int Decrease()
        {
            if (count > minDiapason)
                count--;
            if (count == minDiapason) throw new ArgumentException("Count is equal to minDiapason");

            return count;
        }

        public void Password()
        {
            Console.WriteLine("Counter {0}\t minDiapason = {1}, maxDiapason = {2}", count, minDiapason, maxDiapason);
        }
    }
}
