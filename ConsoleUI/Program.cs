using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 1, CarName = "Fiat",  ColorId = 1, DailyPrice = 100, ModelYear = 2014, Description = "2014 model Fiat Linea" });
            
        }
    }
}
