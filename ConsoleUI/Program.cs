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

            

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description + " : " + item.DailyPrice);
            }
        }
    }
}
