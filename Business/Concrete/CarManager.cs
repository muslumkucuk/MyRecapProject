using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
 
namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;
        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }

        public List<Car> GetAll()
        {
            //İş kodları - if,if... Yetkisi var mı vs? vs
            return _CarDal.GetAll();

        }

        public List<Car> GetCarsByBrandId(int BrandId)
        {
            return _CarDal.GetAll(c => c.BrandId == BrandId);
        }

        public List<Car> GetCarsByColorId(int ColorId)
        {
            return _CarDal.GetAll(c => c.ColorId == ColorId);
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0 && car.ModelYear > 1950)
            {
                _CarDal.Add(car);
            }
        }
        
    }
}
