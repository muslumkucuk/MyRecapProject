using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (MyRecapDatabaseContext myRecapDatabaseContext = new MyRecapDatabaseContext())
            {
                var addedEntity = myRecapDatabaseContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                myRecapDatabaseContext.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (MyRecapDatabaseContext myRecapDatabaseContext = new MyRecapDatabaseContext())
            {
                var deletedEntity = myRecapDatabaseContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                myRecapDatabaseContext.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (MyRecapDatabaseContext myRecapDatabaseContext = new MyRecapDatabaseContext())
            {
                return myRecapDatabaseContext.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (MyRecapDatabaseContext myRecapDatabaseContext = new MyRecapDatabaseContext())
            {
                return filter == null
                    ? myRecapDatabaseContext.Set<Car>().ToList()
                    : myRecapDatabaseContext.Set<Car>().Where(filter).ToList();
            }
        }

        public List<Car> GetCarsByBrandId()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId()
        {
            throw new NotImplementedException();
        }

        public void update(Car entity)
        {
            using (MyRecapDatabaseContext myRecapDatabaseContext = new MyRecapDatabaseContext())
            {
                var updatedEntity = myRecapDatabaseContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                myRecapDatabaseContext.SaveChanges();
            }
        }
    }
}
