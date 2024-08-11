using System.Linq.Expressions;

namespace Nexus.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        T GetById(int id);
        T Get(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);
        IEnumerable<T> GetManyIncluding(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includeProperties);
        T GetIncluding(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includeProperties);
    }
}
