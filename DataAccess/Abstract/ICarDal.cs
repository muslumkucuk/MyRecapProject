﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<Car> GetCarsByBrandId();
        List<Car> GetCarsByColorId();
    }
}
