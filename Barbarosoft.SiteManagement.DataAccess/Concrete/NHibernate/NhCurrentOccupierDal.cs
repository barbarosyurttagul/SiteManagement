using Barbarosoft.Core.DataAccess.NHibernate;
using Barbarosoft.SiteManagement.DataAccess.Abstract;
using Barbarosoft.SiteManagement.Entities.ComplexTypes;
using Barbarosoft.SiteManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barbarosoft.SiteManagement.DataAccess.Concrete.NHibernate
{
    public class NhCurrentOccupierDal : NhEntityRepositoryBase<CurrentOccupier>, ICurrentOccupierDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NhCurrentOccupierDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<CurrentOccupierDetail> GetCurrentOccupiersDetail()
        {
            throw new NotImplementedException();
        }
    }
}
