using System.Data.Entity;
using CarStore.Domain.Entities;

namespace CarStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}