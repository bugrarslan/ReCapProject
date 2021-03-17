using Business.Concrete;
using Core.Entities.Concrete;
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
            //GetAllCar();
            //GetAllColor();
            //GetAllBrand();
            //GetAllCarByBrandId(1);
            //GetAllCarByDailyPrize(100, 200);
            //GetBrandByBrandId(1);
            //RentalAdded();
            //GetAllRental();
            //UserAdded();
            //CustomerAdded();
            CarManager carManager = new CarManager(new EfCarDal(), new BrandManager(new EfBrandDal()));
            carManager.Update(new Car { Id = 2, CarName = "Renault", BrandId = 2, ColorId = 1, ModelYear = 2013, DailyPrice = 150, Description = "2013 model Renault Fluence" });
        }

        private static void CustomerAdded()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { Id = 1, UserId = 1, CompanyName = "Arslan Lojistik" });
        }

        private static void UserAdded()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User { Id = 1, FirstName = "Buğra", LastName = "Arslan", Email = "bgra.arsln@hotmail.com" });
        }

        private static void GetAllRental()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var rent in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rent.Id + "/ " + rent.RentDate + "/ " + rent.ReturnDate);
            }
        }

        private static void RentalAdded()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental { Id = 1, CarId = 1, CustomerId = 1, RentDate = new DateTime(2021, 02, 14), ReturnDate = new DateTime(2021, 02, 25) });
            Console.WriteLine();
        }

        private static void GetBrandByBrandId(int t)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine(brandManager.GetByBrandId(t));
        }

        private static void GetAllCarByDailyPrize(int t1, int t2)
        {
            CarManager carManager = new CarManager(new EfCarDal(), new BrandManager(new EfBrandDal()));
            foreach (var car in carManager.GetByDailyPrice(t1, t2).Data)
            {
                Console.WriteLine(car.CarName);
            }
        }

        private static void GetAllCarByBrandId(int t)
        {
            CarManager carManager = new CarManager(new EfCarDal(), new BrandManager(new EfBrandDal()));
            foreach (var car in carManager.GetByBrandId(t).Data)
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
            colorManager.Add(new Color { Id = 2, ColorName = "Beyaz" });
        }

        private static void GetAllCar()
        {
            CarManager carManager = new CarManager(new EfCarDal(), new BrandManager(new EfBrandDal()));
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("Marka :" + car.CarName + " / Günlük fiyatı : " + car.DailyPrice + " / " + car.Description);
            }
        }

        private static void BrandAdded()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { Id = 2, BrandName = "Renault" });
            Console.WriteLine("Marka eklendi");
        }

        private static void CarAdded()
        {
            CarManager carManager = new CarManager(new EfCarDal(), new BrandManager(new EfBrandDal()));
            carManager.Add(new Car { Id = 3, BrandId = 3, CarName = "Toyota", ColorId = 2, DailyPrice = 350, ModelYear = 2016, Description = "2016 model Toyota Corolla" });


        }
    }
}
