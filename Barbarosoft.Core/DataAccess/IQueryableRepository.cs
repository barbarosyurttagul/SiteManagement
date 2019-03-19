using Barbarosoft.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barbarosoft.Core
{
    //Iqueryable for only Select operations
    public interface IQueryableRepository<T> where T : class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}
