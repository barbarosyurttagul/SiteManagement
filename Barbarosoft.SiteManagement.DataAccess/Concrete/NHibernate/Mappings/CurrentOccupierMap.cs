using Barbarosoft.SiteManagement.Entities.Concrete;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barbarosoft.SiteManagement.DataAccess.Concrete.NHibernate.Mappings
{
    public class CurrentOccupierMap : ClassMap<CurrentOccupier>
    {
        public CurrentOccupierMap()
        {
            Table(@"CurrentOccupiers");
            LazyLoad();
            Id(x => x.CurrentOccupierId).Column("CurrentOccupierId");

            Map(x => x.IdentityNumber).Column("IdentityNumber");
            Map(x => x.FirstMidName).Column("FirstMidName");
            Map(x => x.LastName).Column("LastName");
            Map(x => x.PhoneNumber).Column("PhoneNumber");
            Map(x => x.CheckinDate).Column("CheckinDate");
            Map(x => x.CheckoutDate).Column("CheckoutDate");
            Map(x => x.Landlord).Column("Landlord");
            Map(x => x.Flat.FlatId).Column("FlatId");
        }
    }
}
