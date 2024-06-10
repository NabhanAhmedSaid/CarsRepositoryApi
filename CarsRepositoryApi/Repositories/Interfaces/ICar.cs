using CarsRepositoryApi.Models;

namespace CarsRepositoryApi.Repositories.Interfaces
{
    public interface ICar : IDisposable
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int id);
        int CreatCar(Car car);
        int UpdateCar(Car car);
        int DeleteCar(int id);
    }
}
