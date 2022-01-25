using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IRepository<T> where T:class,IEntities
    {
        IQueryable<T> Table { get; }
        IQueryable<T> TableNoTracking { get; }
        T Get(Expression<Func<T, bool>> filter);
        T GetById(object id);
        IList<T> GetList(Expression<Func<T, bool>> filter = null);

        T Create(T entity);

        void Create(IEnumerable<T> entities);

        void Update(T entity);

        void Update(IEnumerable<T> entities);

        void Delete(T entity);

        void Delete(IEnumerable<T> entities);

        IEnumerable<T> GetSql(string sql);

    }
}
