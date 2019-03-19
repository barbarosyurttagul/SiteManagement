using Barbarosoft.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barbarosoft.SiteManagement.Entities.Concrete
{
    public class Flat : IEntity
    {
        public int FlatId { get; set; }
        public string BlockName { get; set; }
        public string FlatName { get; set; }
    }
}
