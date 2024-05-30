using Models;
using Services;

namespace Controllers
{
    public class CarController
    {
        private CarService _service;

        public CarController()
        {
            _service = new CarService();
        }

        public bool Insert(Car car)
        {
            Console.WriteLine("Camada Controller");
            return _service.Insert(car); 
        }

        public bool Update(Car car)
        {
            Console.WriteLine("Camada Controller");
            return _service.Update(car); 
        }
        public bool Delete(int id) 
        {
            Console.WriteLine("Camada Controller");
            return _service.Delete(id); 
        }
        public Car GetById(int id) 
        {
            Console.WriteLine("Camada Controller");
            return _service.GetById(id); 
        }
        public List<Car> GetAll() 
        {
            Console.WriteLine("Camada Controller");
            return _service.GetAll(); 
        }
    }
    
}
