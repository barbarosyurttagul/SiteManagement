using System;
using System.Collections.Generic;
using System.Text;

namespace Barbarosoft.SiteManagement.Entities.ComplexTypes
{
    public class CurrentOccupierDetail
    {
        public virtual int CurrentOccupierId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string BlockName { get; set; }
        public virtual string FlatName { get; set; }
    }
}
