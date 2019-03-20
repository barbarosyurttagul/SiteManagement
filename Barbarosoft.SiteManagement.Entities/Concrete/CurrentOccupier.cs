using Barbarosoft.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barbarosoft.SiteManagement.Entities.Concrete
{
    public class CurrentOccupier : IEntity
    {
        public virtual int CurrentOccupierId { get; set; }
        public virtual string IdentityNumber { get; set; }
        public virtual string FirstMidName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual bool Landlord { get; set; }
        public virtual DateTime CheckinDate { get; set; }
        public virtual DateTime? CheckoutDate { get; set; }

        public virtual int FlatId { get; set; }
    }
}
