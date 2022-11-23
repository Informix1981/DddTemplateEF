using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data
{
    public interface IAppDbRepository<TEntity> where TEntity : class
    {
        TEntity? GetById(params object[] keyValues);
        public IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity>? FindByCondition(
           Expression<Func<TEntity, bool>>? predicate = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
            bool disableTracking = true);
        public IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>>? filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
            string includeProperties = "");

        public bool CheckIfExist(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entity);

        bool Update(TEntity entity);

        bool Remove(params object[] keyValues);

        public void SaveChanges();
    }
}
