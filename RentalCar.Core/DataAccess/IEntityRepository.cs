using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess;

public interface IEntityRepository<T> where T : class, IEntity, new()
{
    IList<T> GetAllFromDatabase(Expression<Func<T, bool>> filter = null);
    T GetFromDatabase(Expression<Func<T, bool>> filter);
    void AddToDatabase(T entity);
    void UpdateInDatabase(T entity);
    void DeleteFromDatabase(T entity);
}