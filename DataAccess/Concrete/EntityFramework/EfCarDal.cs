using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, MyRecapDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (MyRecapDatabaseContext myRecapDatabaseContext = new MyRecapDatabaseContext())
            {
                var result = from ca in myRecapDatabaseContext.Cars
                             join br in myRecapDatabaseContext.Brands
                             on ca.BrandId equals br.BrandId
                             join co in myRecapDatabaseContext.Colors
                             on ca.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 CarName = ca.CarName, BrandName = br.BrandName,
                                 ColorName = co.ColorName, DailyPrice = ca.DailyPrice
                             };
                return result.ToList();

            }
        }
    }
}