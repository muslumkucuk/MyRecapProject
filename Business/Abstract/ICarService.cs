using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int BrandId);
        List<Car> GetCarsByColorId(int ColorId);
        void Add(Car car);
    } 
}
