using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarAdded();
            //BrandAdded();
            //ColorAdded();
            //GetCarDetails();
            //GetAllCar();
            //GetAllColor();
            //GetAllBrand();
            //GetAllCarByBrandId(1);
            //GetAllCarByDailyPrize(100, 200);
            //GetBrandByBrandId(1);
            RentalAdded();
            //GetAllRental();
        }

        private static void GetAllRental()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var rent in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rent.RentId + "/ " + rent.RentDate + "/ " + rent.ReturnDate);
            }
        }

        private static void RentalAdded()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental { RentId = 1, CarId = 1, CustomerId = 1, RentDate = new DateTime(2021, 02, 14) ,ReturnDate = new DateTime(2021, 02, 20)});
            Console.WriteLine();
        }

        private static void GetBrandByBrandId(int t)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine(brandManager.GetByBrandId(t));
        }

        private static void GetAllCarByDailyPrize(int t1, int t2)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAllByDailyPrice(t1, t2).Data)
            {
                Console.WriteLine(car.CarName);
            }
        }

        private static void GetAllCarByBrandId(int t)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAllByBrandId(t).Data)
            {
                Console.WriteLine(car.CarName);
            }
        }

        private static void GetAllBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void GetAllColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void ColorAdded()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorId = 1, ColorName = "Gri" });
        }

        private static void GetCarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetAllCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
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
            carManager.Add(new Car { CarId = 3, BrandId = 3, CarName = "Toyota", ColorId = 2, DailyPrice = 350, ModelYear = 2016, Description = "2016 model Toyota Corolla" });
            
            
        }
    }
}
