using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<RentalDetailDto>> GetAll();
        IDataResult<Rental> GetByRentId(int Id);
        IResult Add(Rental rent);
        IResult Delete(Rental rent);
        IResult Update(Rental rent);
    }
}
