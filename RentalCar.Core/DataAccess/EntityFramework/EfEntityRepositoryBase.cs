using System.Linq.Expressions;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework;

public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> 
    where TEntity : class, IEntity, new() 
    where TContext : DbContext, new() 
{
    public IList<TEntity> GetAllFromDatabase(Expression<Func<TEntity, bool>> filter = null)
    {
        using var context = new TContext();
        return filter == null
            ? context.Set<TEntity>().ToList()
            : context.Set<TEntity>().Where(filter).ToList();
    }

    public TEntity GetFromDatabase(Expression<Func<TEntity, bool>> filter)
    {
        using var context = new TContext();
        return context.Set<TEntity>().SingleOrDefault(filter);
    }

    public void AddToDatabase(TEntity entity)
    {
        using var context = new TContext();
        var entityToAdd = context.Entry(entity);
        entityToAdd.State = EntityState.Added;
        context.SaveChanges();
    }

    public void UpdateInDatabase(TEntity entity)
    {
        using var context = new TContext();
        var entityToUpdate = context.Entry(entity);
        entityToUpdate.State = EntityState.Unchanged;
        context.SaveChanges();
    }

    public void DeleteFromDatabase(TEntity entity)
    {
        using var context = new TContext();
        var entityToDelete = context.Entry(entity);
        entityToDelete.State = EntityState.Deleted;
        context.SaveChanges();
    }
}