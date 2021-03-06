using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join Co in context.Colors
                             on c.ColorId equals Co.Id
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 DailyPrice = c.DailyPrice,
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = Co.ColorName
                             };
                return result.ToList();
            }
        }
    }
}
