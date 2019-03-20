using Barbarosoft.Core.DataAccess.EntityFramework;
using Barbarosoft.SiteManagement.DataAccess.Abstract;
using Barbarosoft.SiteManagement.Entities.ComplexTypes;
using Barbarosoft.SiteManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barbarosoft.SiteManagement.DataAccess.Concrete.EntityFramework
{
    public class EfCurrentOccupierDal : EfEntityRepositoryBase<CurrentOccupier, SiteManagementContext>, ICurrentOccupierDal
    {
        public List<CurrentOccupierDetail> GetCurrentOccupiersDetail()
        {
            using (SiteManagementContext context = new SiteManagementContext())
            {
                var result = from c in context.CurrentOccupiers 
                             join f in context.Flats on c.FlatId equals f.FlatId
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
