using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
               new Car{CarId = 1, CarName = "Tucson", BrandId = 1, BrandName = "Hyundai", ColorId = 1, DailyPrice = 100000, ModelYear = "2012" , Description = "Askere gidecem satıyorum" },
               new Car{CarId = 2, CarName = "Model S", BrandId = 2, BrandName = "Tesla", ColorId = 2, DailyPrice = 800000, ModelYear = "2018" , Description = "Hafif vurdum" },
               new Car{CarId = 3, CarName = "Maybach", BrandId = 3, BrandName = "Mercedes", ColorId = 3, DailyPrice = 1000000, ModelYear = "2016" , Description = "Saraylara layık" },
               new Car{CarId = 4, CarName = "Civic", BrandId = 4, BrandName = "Honda", ColorId = 2, DailyPrice = 200000, ModelYear = "2014" , Description = "Dosta gider" },
               new Car{CarId = 5, CarName = "Focus", BrandId = 5, BrandName = "Ford", ColorId = 1, DailyPrice = 150000, ModelYear = "2020" , Description = "Pazarlık payı yoktur" }
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.CarId == car.CarId);

            _cars.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            Car car;
            car = _cars.SingleOrDefault(c=> c.CarId == id);
            return car;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarName = car.CarName;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.BrandName = car.BrandName;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
