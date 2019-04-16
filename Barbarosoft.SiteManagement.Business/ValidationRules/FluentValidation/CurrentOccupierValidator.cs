using Barbarosoft.SiteManagement.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barbarosoft.SiteManagement.Business.ValidationRules.FluentValidation
{
    public class CurrentOccupierValidator : AbstractValidator<CurrentOccupier>
    {
        public CurrentOccupierValidator()
        {
            RuleFor(x => x.FirstMidName).Length(4, 25).NotEmpty().WithMessage("Harf Fazla");
            //RuleFor(x => x.CheckinDate).NotEmpty();
            RuleFor(x => x.FlatId).LessThan(5).WithMessage("Rakam fazla");
        }
    }
}
