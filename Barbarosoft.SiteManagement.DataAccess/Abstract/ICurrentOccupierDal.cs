using Barbarosoft.Core;
using Barbarosoft.SiteManagement.Entities.ComplexTypes;
using Barbarosoft.SiteManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barbarosoft.SiteManagement.DataAccess.Abstract
{
    public interface ICurrentOccupierDal : IEntityRepository<CurrentOccupier>
    {
        List<CurrentOccupierDetail> GetCurrentOccupiersDetail();
        //Additional methods to be added here
    }
}
