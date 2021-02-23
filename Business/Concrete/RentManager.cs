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
    public class RentManager : IRentService
    {

        IRentDal _rentDal;

        public RentManager(IRentDal rentDal)
        {
            _rentDal = rentDal;
        }

        public IResult Add(Rent rent)
        {
            if (rent.ReturnDate == null)
            {
                return new ErrorResult(Messages.CarIsNotEmpty);
            }
            _rentDal.Add(rent);

            return new SuccessResult(Messages.RentAdded);
        }

        public IResult Delete(Rent rent)
        {
            _rentDal.Delete(rent);
            return new SuccessResult(Messages.RentDeleted);
        }

        public IDataResult<List<RentDetailDto>> GetAll()
        {
            return new SuccessDataResult<List<RentDetailDto>>(Messages.Rentslisted);
        }

        public IDataResult<Rent> GetByRentId(int Id)
        {
            return new SuccessDataResult<Rent>();
        }

        public IResult Update(Rent rent)
        {
            _rentDal.Update(rent);
            return new SuccessResult(Messages.RentUpdated);
        }
    }
}
