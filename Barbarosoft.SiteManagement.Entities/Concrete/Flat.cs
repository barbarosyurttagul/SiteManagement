using Barbarosoft.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barbarosoft.SiteManagement.Entities.Concrete
{
    public class Flat : IEntity
    {
        public virtual int FlatId { get; set; }
        public virtual string BlockName { get; set; }
        public virtual string FlatName { get; set; }
    }
}
