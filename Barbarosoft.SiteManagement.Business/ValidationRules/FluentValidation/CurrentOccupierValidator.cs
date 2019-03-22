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
            RuleFor(x => x.FirstMidName).NotEmpty();
            RuleFor(x => x.CheckinDate).NotEmpty();
            RuleFor(x => x.FlatId).NotEmpty();
        }
    }
}
