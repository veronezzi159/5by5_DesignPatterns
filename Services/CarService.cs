using Models;
using Repositories;

namespace Services
{
    public class CarService
    {
        private CarRepository carRepository;

        public CarService()
        {
            carRepository = new CarRepository();
        }


        public bool Insert(Car car)
        {
            Console.WriteLine("Camada Service");

            return carRepository.Insert(car);
        }
        public bool Update(Car car) 
        {

        Console.WriteLine("Camada Service");

            return carRepository.Update(car);
        }
        public bool Delete(int id) 
        {
            Console.WriteLine("Camada Service");

            return carRepository.Delete(id);
        }
        public Car GetById(int id) 
        {
            Console.WriteLine("Camada Service");

            return carRepository.GetById(id);
        }
        public List<Car> GetAll() 
        {
            Console.WriteLine("Camada Service");

            return carRepository.GetAll();
        }
    }
}
