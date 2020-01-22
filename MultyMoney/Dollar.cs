using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultyMoney
{
    class Dollar:Money
    {
        int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public Dollar()
        {
            amount=0;
        }

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public int times(int multipier)
        {
            return amount *= multipier;
        }

        //Dollar times(int multiplier)
        //{
        //    amount *= multiplier;
        //    return new Dollar;
        //}

        public bool equals(Dollar dollar)
        {
            Dollar dollar1 = (Dollar)dollar;
            return amount == dollar1.amount;
            //return true;
        }


    }
}
