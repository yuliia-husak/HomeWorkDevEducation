using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork24022020_ObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ObservableCollection<Phone> closesPhone = new ObservableCollection<Phone>
            {
                new Phone { Model = "Apple", Price=25000.00},
                new Phone { Model = "Huiwei", Price=13500.10},
                new Phone { Model = "Samsung", Price=18969.50}
            };

            closesPhone.CollectionChanged += Phones_CollectionChanged;

            closesPhone.Add(new Phone { Model = "Apple JJJ", Price = 45000.00 });
            closesPhone.RemoveAt(1);
            closesPhone[1] = new Phone { Model = "Sony", Price = 11300.00 };

            foreach (Phone phone in closesPhone)
            {
                Console.WriteLine(phone.Model + "  " + phone.Price);
            }

            Console.Read();
        }

        private static void Phones_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    Phone newPhone = e.NewItems[0] as Phone;
                    Console.WriteLine($"Добавлен новый объект: {newPhone.Model} {newPhone.Price}");
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    Phone oldPhone = e.OldItems[0] as Phone;
                    Console.WriteLine($"Удален объект: {oldPhone.Model} {oldPhone.Price}");
                    break;
                case NotifyCollectionChangedAction.Replace: // если замена
                    Phone replacedPhone = e.OldItems[0] as Phone;
                    Phone replacingPhone = e.NewItems[0] as Phone;
                    Console.WriteLine($"Объект {replacedPhone.Model} заменен объектом {replacingPhone.Model}");
                    break;
            }
        }
    }

}
    
