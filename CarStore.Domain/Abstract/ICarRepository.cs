using CarStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Domain.Abstract
{
    public interface ICarRepository
    {
        IEnumerable<Car>  Cars {get;}
    }
}
