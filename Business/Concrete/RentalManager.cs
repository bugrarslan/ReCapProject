using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {

        IRentalDal _rentDal;

        public RentalManager(IRentalDal rentDal)
        {
            _rentDal = rentDal;
        }

        public IResult Add(Rental rent)
        {
            if (rent.ReturnDate == null)
            {
                return new ErrorResult(Messages.CarIsNotEmpty);
            }
            _rentDal.Add(rent);

            return new SuccessResult(Messages.RentAdded);
        }

        public IResult Delete(Rental rent)
        {
            _rentDal.Delete(rent);
            return new SuccessResult(Messages.RentDeleted);
        }

        public IDataResult<List<RentalDetailDto>> GetAll()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(Messages.Rentslisted);
        }

        public IDataResult<Rental> GetByRentId(int Id)
        {
            return new SuccessDataResult<Rental>();
        }

        public IResult Update(Rental rent)
        {
            _rentDal.Update(rent);
            return new SuccessResult(Messages.RentUpdated);
        }
    }
}
