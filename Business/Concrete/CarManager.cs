using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
 
namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            //İş kodları - if,if... Yetkisi var mı vs? vs
            return _carDal.GetAll();

        }

        public List<Car> GetCarsByBrandId(int BrandId)
        {
            return _carDal.GetAll(c => c.BrandId == BrandId);
        }

        public List<Car> GetCarsByColorId(int ColorId)
        {
            return _carDal.GetAll(c => c.ColorId == ColorId);
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0 && car.ModelYear > 1950)
            {
                _carDal.Add(car);
            }
        }

        public List<CarDetailDto> GetCarDetails()
        {
            //iş kuralı
            return _carDal.GetCarDetails();
        }
    }
}
