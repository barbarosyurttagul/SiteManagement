using Barbarosoft.SiteManagement.Business.Abstract;
using Barbarosoft.SiteManagement.DataAccess.Abstract;
using Barbarosoft.SiteManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Barbarosoft.SiteManagement.Business.Concrete.Managers
{
    public class FlatManager : IFlatService
    {
        private readonly IFlatDal _flatDal;

        public FlatManager(IFlatDal flatDal)
        {
            _flatDal = flatDal;
        }

        public Flat Add(Flat entity)
        {
            return _flatDal.Add(entity);
        }

        public void Delete(Flat entity)
        {
            _flatDal.Delete(entity);
        }

        public Flat Get(Expression<Func<Flat, bool>> filter)
        {
            return _flatDal.Get(filter);
        }

        public List<Flat> GetList(Expression<Func<Flat, bool>> filter = null)
        {
            return _flatDal.GetList(filter);
        }

        public Flat Update(Flat entity)
        {
            return _flatDal.Update(entity);
        }
    }
}
