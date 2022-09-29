using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1,BrandId = 1,ColorId = 1,DailyPrice = 1500,ModelYear = 2017,Description = "1.6 Toyota Dizel Otomatik"},
                new Car{CarId = 2,BrandId = 2,ColorId = 1,DailyPrice = 2500,ModelYear = 2018,Description = "1.18 Bmw Dizel Otomatik"},
                new Car{CarId = 3,BrandId = 3,ColorId = 2,DailyPrice = 3500,ModelYear = 2019,Description = "1.5  Hyundai Benzin Manuel"},
                new Car{CarId = 4,BrandId = 4,ColorId = 2,DailyPrice = 4500,ModelYear = 2020,Description = "1.8 Audi Benzin Manuel"},
                new Car{CarId = 5,BrandId = 5,ColorId = 3,DailyPrice = 5500,ModelYear = 2022,Description = "1.6 Mercedes Benzin Otomatik"},

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);

        }

        public void Delete(Car car)
        {
            Car carToDelete =  _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllById(int carId)

        {
            return _cars.Where(c => c.CarId == carId).ToList();

        }

        public void Update(Car car)
        {
            
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            

        }
    }
}
