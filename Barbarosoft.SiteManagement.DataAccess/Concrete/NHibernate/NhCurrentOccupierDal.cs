using Barbarosoft.Core.DataAccess.NHibernate;
using Barbarosoft.SiteManagement.DataAccess.Abstract;
using Barbarosoft.SiteManagement.Entities.ComplexTypes;
using Barbarosoft.SiteManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
            using (var session = _nHibernateHelper.OpenSession())
            {
                var result = from c in session.Query<CurrentOccupier>()
                             join f in session.Query<Flat>() on c.FlatId equals f.FlatId
                             select new CurrentOccupierDetail
                             {
                                 CurrentOccupierId = c.CurrentOccupierId,
                                 FirstName = c.FirstMidName,
                                 LastName = c.LastName,
                                 BlockName = f.BlockName,
                                 FlatName = f.FlatName
                             };
                return result.ToList();
            }
        }
    }
}
