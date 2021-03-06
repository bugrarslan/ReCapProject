using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentDal : EfEntityRepositoryBase<Rent, ReCapProjectContext>, IRentDal
    {
        public List<RentDetailDto> GetRentDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from r in context.Rents
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join cu in context.Customers
                             on r.CustomerId equals cu.Id
                             select new RentDetailDto
                             {
                                 RentId = r.Id,
                                 CarId = c.Id,
                                 CustomerId = cu.Id,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                             };

                return result.ToList();
               
            }
        }
    }
}
