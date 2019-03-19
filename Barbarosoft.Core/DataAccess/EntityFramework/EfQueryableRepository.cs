using Barbarosoft.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barbarosoft.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository<T> : IQueryableRepository<T>
        where T : class, IEntity, new()
    {
        private DbContext _context;
        private IQueryable<T> _entities;

        public EfQueryableRepository(DbContext context)
        {
            _context = context;
        }

        public IQueryable<T> Table => this.Entities;

        protected virtual IQueryable<T> Entities
        {
            
            get { return _entities ?? (_entities = _context.Set<T>()); }
        }
        
        //IQueryable<T> IQueryableRepository<T>.Table => throw new NotImplementedException();
    }
}
