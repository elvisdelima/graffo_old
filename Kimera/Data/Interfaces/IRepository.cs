using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kimera.Models.Interfaces;

namespace Kimera.Data
{
    public interface IRepository<T>: IDisposable
    {
        T Add(T entidade);
        void Update(T entidade);

        void Delete(T entidade);
        void Delete(long id);

        long Total { get; }
        T Last { get; }
        T Find(long id);

        IQueryable<T> Query { get; }

        bool Exists(long id);
        void Save();
        void Detach(T entity);
    }
}