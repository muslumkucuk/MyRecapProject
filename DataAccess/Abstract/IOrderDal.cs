using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess
{
    public interface IOrderDal : IEntityRepository<Order>
    {

    }
}
