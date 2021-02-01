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
        public List<Car> GetById(int id)
        {
            return _CarDal.GetById(id);
        }
    }
}
