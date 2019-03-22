using Barbarosoft.Core.CrossCuttingConcerns.Validation.FluentValidation;
using Barbarosoft.SiteManagement.Business.Abstract;
using Barbarosoft.SiteManagement.Business.ValidationRules.FluentValidation;
using Barbarosoft.SiteManagement.DataAccess.Abstract;
using Barbarosoft.SiteManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Barbarosoft.SiteManagement.Business.Concrete.Managers
{
    public class CurrentOccupierManager : ICurrentOccupierService
    {
        private readonly ICurrentOccupierDal _currentOccupierDal;

        public CurrentOccupierManager(ICurrentOccupierDal currentOccupierDal)
        {
            _currentOccupierDal = currentOccupierDal;
        }

        public CurrentOccupier Add(CurrentOccupier entity)
        {
            ValidatorTool.FluentValidate(new CurrentOccupierValidator(), entity);
            return _currentOccupierDal.Add(entity);
        }

        public void Delete(CurrentOccupier entity)
        {
            _currentOccupierDal.Delete(entity);
        }

        public CurrentOccupier Get(Expression<Func<CurrentOccupier, bool>> filter)
        {
            return _currentOccupierDal.Get(filter);
        }

        public List<CurrentOccupier> GetList(Expression<Func<CurrentOccupier, bool>> filter = null)
        {
            return _currentOccupierDal.GetList(filter);
        }

        public CurrentOccupier Update(CurrentOccupier entity)
        {
            return _currentOccupierDal.Update(entity);
        }
    }
}
