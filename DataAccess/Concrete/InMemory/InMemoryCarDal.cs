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
                new Car{ Id = 1, BrandId = 1, ColorId = 5, DailyPrice = 200, ModelYear = 2012, Description = "2012 model BMW 520i"},
                new Car{ Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 150, ModelYear = 2009, Description = "2009 model BMW 320i"},
                new Car{ Id = 3, BrandId = 3, ColorId = 2, DailyPrice = 500, ModelYear = 2015, Description = "2015 model Volswagen Passat"},
                new Car{ Id = 4, BrandId = 6, ColorId = 6, DailyPrice = 1000, ModelYear = 2019, Description = "2019 model Mercedes Mayback"},
                new Car{ Id = 5, BrandId = 2, ColorId = 8, DailyPrice = 650, ModelYear = 2014, Description = "2014 model Audi A5"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        List<Car> IEntityRepository<Car>.GetAll()
        {
            return _cars;
        }

        List<Car> IEntityRepository<Car>.GetById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }
    }
}
