using CarsRepositoryApi.Data;
using CarsRepositoryApi.Models;
using CarsRepositoryApi.Repositories.Interfaces;

namespace CarsRepositoryApi.Repositories.Implementations
{
    public class CarRepository : ICar
    {
        private readonly ApplicationDBContext _context;

        public CarRepository(ApplicationDBContext db)
        {
            _context = db;  
        }
        public int CreatCar(Car car)
        {
            var result = -1;
            if (car == null)
            {
                result = 0;
            }
            else
            {
                _context.Cars.Add(car);
                _context.SaveChanges(); 
                result = car.Id;
            }
            return result;  
        }

        public int DeleteCar(int id)
        {
            if (id == 0)
            {
                return -1;
            }
            var x = _context.Cars.Where(x=>x.Id== id).FirstOrDefault();
            if (x != null)
            {
                _context.Cars.Remove(x);
                _context.SaveChanges();
                return x.Id;
            }
            return 0;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetAllCars()
        {
            var y = _context.Cars.ToList();
            return y;
        }

        public Car GetCarById(int id)
        {
            var y = _context.Cars.Where(x => x.Id == id).FirstOrDefault()?? null;
             return y;

            
        }

        public int UpdateCar(Car car)
        {
        var y = _context.Cars.Where(x=>x.Id == car.Id).FirstOrDefault() ?? null;
            if (y != null)
            {
                y.Id = car.Id;
                y.Name = car.Name;
                y.Brand = car.Brand;
                y.Color = car.Color;
            }
            return -1;
        }
    }
}
