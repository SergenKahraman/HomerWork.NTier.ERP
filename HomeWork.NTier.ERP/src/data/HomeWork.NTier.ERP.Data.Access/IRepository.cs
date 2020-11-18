using HomeWork.NTier.ERP.Data.Entities.Abstractions;
using System.Linq;

namespace HomeWork.NTier.ERP.Data.Access
{
    public interface IRepository<T> : IQueryable<T> where T : EntityBase
    {
        void Add(T entity);

        int Save();
    }
}