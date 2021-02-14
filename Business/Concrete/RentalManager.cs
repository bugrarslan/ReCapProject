using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {

        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            //if (rental.ReturnDate == null)
            //{
            //    return new ErrorResult(Messages.CarIsNotEmpty);
            //}
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.Rentalslisted);
        }

        public IDataResult<Rental> GetByUserId(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.RentId == id));
        }

        public IDataResult<List<RentalDetailDto>> GetUserDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        public IResult Update(Rental rental)
        {
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
