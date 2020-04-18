using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStore.Domain.Entities;
using CarStore.Domain.Abstract;

namespace CarStore.Domain.Concrete
{
    public class EFCarRepository : ICarRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Car> Cars
        {
            get { return context.Cars; }
        }

        public void SaveCar(Car car)
        {
            if (car.CarId == 0)
                context.Cars.Add(car);
            else
            {
               Car dbEntry = context.Cars.Find(car.CarId);
                if (dbEntry != null)
                {
                    dbEntry.Name = car.Name;
                    dbEntry.Description = car.Description;
                    dbEntry.Price = car.Price;
                    dbEntry.Category = car.Category;
                }
            }
            context.SaveChanges();
        }
    }
}
