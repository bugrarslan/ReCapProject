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
            //CarAdded();
            //BrandAdded();
            //GetAllCar();
            ColorAdded();
            GetCarDetails();
        }

        private static void ColorAdded()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorId = 1, ColorName = "Gri" });
            Console.WriteLine("Renk eklendi");
        }

        private static void GetCarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            }
        }

        private static void GetAllCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Marka :" + car.CarName + " / Günlük fiyatı : " + car.DailyPrice + " / " + car.Description);
            }
        }

        private static void BrandAdded()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandId = 2, BrandName = "Renault" });
            Console.WriteLine("Marka eklendi");
        }

        private static void CarAdded()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { CarId = 2, BrandId = 2, CarName = "Renault", ColorId = 1, DailyPrice = 150, ModelYear = 2013, Description = "20143 model Renault Fluence" });
            Console.WriteLine("Araç eklendi");
        }
    }
}
