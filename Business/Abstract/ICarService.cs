﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<CarDetailDto>> GetAll();
        IDataResult<List<CarDetailDto>> GetByBrandId(int id);
        IDataResult<List<CarDetailDto>> GetByColorId(int id);
        IDataResult<List<CarDetailDto>> GetByDailyPrice(int min, int max);
        IDataResult<List<CarDetailDto>> GetByCarId(int Id);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
    }
}
