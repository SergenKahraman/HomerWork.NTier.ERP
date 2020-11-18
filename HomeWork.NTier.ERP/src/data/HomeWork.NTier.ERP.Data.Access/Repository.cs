using HomeWork.NTier.ERP.Data.Context;
using HomeWork.NTier.ERP.Data.Entities.Abstractions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace HomeWork.NTier.ERP.Data.Access
{
    public class Repository<T> : IRepository<T> where T : EntityBase //normalde bunu interface yaptık ama filtreleme class istediği için mecbur base classa döndük
    {
        private readonly NorthwindDBContext context;
        private readonly DbSet<T> table;

        public Repository()
        {
            context = new NorthwindDBContext();
            table = context.Set<T>();
        }

        public Expression Expression => table.AsQueryable().Expression;

        public Type ElementType => table.AsQueryable().ElementType;

        public IQueryProvider Provider => table.AsQueryable().Provider;

        IEnumerator IEnumerable.GetEnumerator() //TODO:  bu kısmı tam anlamadım
        {
            return table.AsEnumerable().GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return table.AsEnumerable().GetEnumerator();
        }

        public void Add(T entity)
        {
            table.Add(entity);
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}