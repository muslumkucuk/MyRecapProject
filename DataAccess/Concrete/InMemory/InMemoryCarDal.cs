using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car; // Asuming that "_car" is our database.
        public InMemoryCarDal()
        {
            _car = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=4,ModelYear=2012,DailyPrice=300,Description="Yeni ve temiz"},
                new Car{Id=2,BrandId=1,ColorId=2,ModelYear=2017,DailyPrice=500,Description="Yeni ve şık"},
                new Car{Id=3,BrandId=2,ColorId=7,ModelYear=2020,DailyPrice=750,Description="Yeni,temiz,güzel"},
                new Car{Id=4,BrandId=3,ColorId=7,ModelYear=2014,DailyPrice=380,Description="Yeni,temiz,bakımlı"},
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(p => p.Id == id).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _car;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void update(Car entity)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId()
        {
            throw new NotImplementedException();
        }
    }
}
