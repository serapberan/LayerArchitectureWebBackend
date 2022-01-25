using DataAccess.Entities;
using DataAccess.EntitiyFramework.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntitiyFramework
{
    public class EfRepositoryBase<T> : IRepository<T> where T : class, IEntities
    {
        private readonly AsliContext _context;
        private DbSet<T> _entities;

        public EfRepositoryBase(AsliContext asliContext)
        {
            _context = asliContext; 
            _entities=_context.Set<T>();    
        }
        protected virtual DbSet<T> Entities => _entities ??= _context.Set<T>();
        public IQueryable<T> Table => Entities;

        public IQueryable<T> TableNoTracking => Entities.AsNoTracking();

       

        public T Create(T entity)
        {
            if (entity == null)
            
                throw new ArgumentNullException(nameof(entity));

            _context.Add(entity);   
            _context.SaveChanges(); 
            return entity;  
            
        }
        public void Create(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));
            _context.AddRange(entities);
            _context.SaveChanges();
        }
        public void Delete(T entity)
        {   if(entity == null)
                throw new ArgumentNullException(nameof(entity));
            Entities.Remove(entity);
            _context.SaveChanges();
        }

        public void Delete(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));
            Entities.RemoveRange(entities);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return Entities.SingleOrDefault(filter);
        }

        public T GetById(object id)
        {
            return Entities.Find(id);
        }

        public IList<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            var result=filter == null ?
                _context.Set<T>().ToList() :    
                _context.Set<T>().Where(filter).ToList();
            return result;  
        }

        public IEnumerable<T> GetSql(string sql)
        {
           return Entities.FromSqlRaw(sql); 
        }

        public void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _context.SaveChanges();
           
        }

        public void Update(IEnumerable<T> entities)
        {
            if(entities == null)
                throw new ArgumentNullException(nameof(entities));
            _context.SaveChanges();
        }

        
    }
}
