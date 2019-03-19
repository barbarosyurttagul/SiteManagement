using Barbarosoft.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Barbarosoft.Core
{
    /* where is used for limiting the developers about generic type T. 
    *  So T can only be a class, IEntity(empty interface for only marking) and 
    *  new(): for example, abstract classes can not be new()ed.
    */
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //If filter=null GetAll, if not get results up to filter
        //Task<List<T>> GetList(Expression<Func<T, bool>> filter = null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        //Get only one
        T Get(Expression<Func<T, bool>> filter);

        T Add(T entity);

        T Update(T entity);

        void Delete(T entity);
    }
}
