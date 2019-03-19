using Barbarosoft.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barbarosoft.SiteManagement.Entities.Concrete
{
    public class CurrentOccupier : IEntity
    {
        public int CurrentOccupierId { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool Landlord { get; set; }
        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }

        public virtual Flat Flat { get; set; }
    }
}
