using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_001_Classes
{
    class Money
    {
        //o	Поля:
        private int first;//номинал купюры
        private	int second; //количество купюр
        //o Конструктор, позволяющий создать экземпляр класса с заданными значениям полей.
        public Money(int f, int s)
        {
            this.first = f;
            this.second = s;
        }
        //o Методы, позволяющие:
        //▪	вывести номинал и количество купюр;
        public void Show()
        {
            Console.WriteLine("You have {0} bills of {1} par", 
                first, second);            
        }
        //▪	определить, хватит ли денежных средств на покупку товара на сумму N рублей.
        public int BuyGoods(int x)
        {
            int BuyGood = AmountMoney / x;
            if (BuyGood < 0)
            {
                Console.Write("You can't buy this good, your balance smaller: ");
                return BuyGood;
            }
            Console.Write("You can buy this good: ");
            return BuyGood;
        }
        //▪	определить, сколько шт товара стоимости n рублей можно купить на имеющиеся денежные средства.
        private int buygoods()
        {
            Console.Write("Enter, please, cost good: ");
            int costgood = int.Parse(Console.ReadLine());
            return AmountMoney / costgood;
        }
        //o   Свойства:
        //▪	позволяющее получить-установить значение полей (доступное для чтения и записи);
        public int First
        {
            get => first;
            set => first = value;
        }
        public int Second
        {
            get => second;
            set => second = value;
        }
        //▪	позволяющее рассчитать сумму денег(доступное только для чтения).
        public int AmountMoney
        {
            get { return first * second; }
        }

    }
}
