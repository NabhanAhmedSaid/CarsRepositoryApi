using CarsRepositoryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CarsRepositoryApi.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options) 
        {

        }
        public virtual DbSet<Car> Cars { get; set; }
    }
}
