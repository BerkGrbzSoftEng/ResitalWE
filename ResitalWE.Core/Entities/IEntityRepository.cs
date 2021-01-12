using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ResitalWE.Core.Entities
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {

        T Get(int id);
        IList<T> GetList(Expression<Func<T, bool>> filter = null);

        //Select Ad,Soyad from Table
        IQueryable<TResult> GetAllSelect<TResult>(Expression<Func<T, TResult>> select);
        //Select Ad,Soyad from Table where no>10
        IQueryable<TResult> GetAllSelect<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> select);
        decimal Max(Expression<Func<T, bool>> filter, Expression<Func<T, decimal>> column);
        decimal Min(Expression<Func<T, bool>> filter, Expression<Func<T, decimal>> column);
        int? Max(Expression<Func<T, bool>> filter, Expression<Func<T, Nullable<int>>> column);
        int? Min(Expression<Func<T, bool>> filter, Expression<Func<T, Nullable<int>>> column);
        decimal Sum(Expression<Func<T, bool>> filter, Expression<Func<T, Nullable<decimal>>> column);
        int Count(Expression<Func<T, bool>> filter=null);
    }
}
