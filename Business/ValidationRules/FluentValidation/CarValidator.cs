using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty().WithMessage(Messages.CarNameEmpty);
            RuleFor(c => c.CarName).MinimumLength(2).WithMessage(Messages.CarNameInvalid);
            RuleFor(c => c.DailyPrice).NotEmpty().WithMessage(Messages.DailyPriceEmpty);
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage(Messages.DailyPriceInvalid);
            //RuleFor(c => c.CarName).Must(StartWithA);
        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
