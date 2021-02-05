using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description + " : " + item.DailyPrice );
            }

            carManager.Add( new Entities.Concrete.Car { Id = 6, BrandId = 4, ColorId = 2, DailyPrice = 100, Description = "2010 Model Toyota Corolla", ModelYear = 2010 });

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description + " : " + item.DailyPrice);
            }
        }
    }
}
