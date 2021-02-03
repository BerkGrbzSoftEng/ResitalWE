using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResitalWE.Core.Entities;

namespace ResitalWE.Core.DataAccess
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
    where TEntity:class,IEntity,new()
    where TContext:DbContext,new()
    {
        
        #region Min Operation

        public decimal Min(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, decimal>> column)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Where(filter).Min(column);
            }
        }

        public int? Min(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, int?>> column)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Where(filter).Min(column);
            }
        }
        #endregion

        #region Max Operation
        public decimal Max(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, decimal>> column)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Where(filter).Max(column);
            }
        }

        public int? Max(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, int?>> column)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Where(filter).Max(column);
            }
        }
        #endregion

        #region List Operation
        public IQueryable<TResult> GetAllSelect<TResult>(Expression<Func<TEntity, TResult>> select)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Select(select);
            }
        }

        public IQueryable<TResult> GetAllSelect<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> select)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Where(filter).Select(select);
            }

        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList(); 
            }
        }

        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return  filter == null
                    ? await context.Set<TEntity>().ToListAsync()
                    : await context.Set<TEntity>().Where(filter).ToListAsync();
            }
        }
        #endregion

        #region Count-Sum Operation
        public int Count(Expression<Func<TEntity, bool>> filter=null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().Count()
                    : context.Set<TEntity>().Where(filter).Count();
            }
        }
        public decimal Sum(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, decimal?>> column)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Where(filter).Sum(column) ?? 0;
            }
        }
        #endregion

        #region Object Operation


        public TEntity Get(int id)
        {
            using (var context = new TContext())
            {
                var obj = context.Set<TEntity>().Find(id);
                return obj;
            }
        }
        #endregion
    }
}
