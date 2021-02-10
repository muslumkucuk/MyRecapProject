using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity: class,IEntity,new()
        where TContext: DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (TContext myRecapDatabaseContext = new TContext())
            {
                var addedEntity = myRecapDatabaseContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                myRecapDatabaseContext.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext myRecapDatabaseContext = new TContext())
            {
                var deletedEntity = myRecapDatabaseContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                myRecapDatabaseContext.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext myRecapDatabaseContext = new TContext())
            {
                return myRecapDatabaseContext.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext myRecapDatabaseContext = new TContext())
            {
                return filter == null
                    ? myRecapDatabaseContext.Set<TEntity>().ToList()
                    : myRecapDatabaseContext.Set<TEntity>().Where(filter).ToList();
            }
        }

        public List<TEntity> GetCarsByBrandId()
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetCarsByColorId()
        {
            throw new NotImplementedException();
        }

        public void update(TEntity entity)
        {
            using (TContext myRecapDatabaseContext = new TContext())
            {
                var updatedEntity = myRecapDatabaseContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                myRecapDatabaseContext.SaveChanges();
            }
        }
    }
}
