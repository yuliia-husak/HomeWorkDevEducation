using System.Collections.Generic;
using CarStore.Domain.Entities;

namespace CarStore.WebUI.Models
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> Cars { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}