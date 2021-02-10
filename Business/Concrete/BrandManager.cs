using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public List<Brand> GetAll()
        {
            //İş kodları
            return _brandDal.GetAll();
        }

        //SELECT * FROM BRANDS WHERE BRANDID=3
        public Brand GetByBrandId(int brandId)
        {
            //İş Kodları
            return _brandDal.Get(b => b.BrandId == brandId);
        }
    }
}
