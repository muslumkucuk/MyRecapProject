using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brand; //Asuming that "_brand" is our database
        public InMemoryBrandDal()
        {
            _brand = new List<Brand>
            {
                new Brand{BrandId=1,BrandName="Toyota"},
                new Brand{BrandId=2,BrandName="Tesla"},
                new Brand{BrandId=3,BrandName="Citroén"},
                new Brand{BrandId=4,BrandName="Peugeot"},
            };
        }

        public void Add(Brand brand)
        {
            _brand.Add(brand);
        }

        public void Delete(Brand entity)
        {
            throw new NotImplementedException();
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void update(Brand entity)
        {
            throw new NotImplementedException();
        }
    }
}

