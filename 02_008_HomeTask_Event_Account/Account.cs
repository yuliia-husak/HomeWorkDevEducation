using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_008_HomeTask_Event_Account
{
    class Account
    {
        public delegate void AccountHandler(object sender, AccountEventArgs e);
        public event AccountHandler Notify;
        public Account(int sum)
        {
            Sum = sum;
        }

        public int Sum { get; private set; }
        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke(this, new AccountEventArgs($"На счет поступило: {sum}",sum));
        }

        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke(this, new AccountEventArgs($"Со счета снято: {sum}",sum));
            }
            else
            {
                Notify?.Invoke(this, new AccountEventArgs($"Недостаточно денег на счете. " +
                    $"Текущий баланс: {Sum}",sum));
            }
        }

    }
}
