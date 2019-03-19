using Barbarosoft.Core.DataAccess.EntityFramework;
using Barbarosoft.SiteManagement.DataAccess.Abstract;
using Barbarosoft.SiteManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barbarosoft.SiteManagement.DataAccess.Concrete.EntityFramework
{
    public class EfCurrentOccupierDal : EfEntityRepositoryBase<CurrentOccupier, SiteManagementContext>, ICurrentOccupierDal
    {

    }
}
