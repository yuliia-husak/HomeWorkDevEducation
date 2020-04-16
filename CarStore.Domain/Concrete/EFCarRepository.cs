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
    }
}
