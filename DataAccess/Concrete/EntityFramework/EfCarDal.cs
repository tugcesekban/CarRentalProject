using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarEntityContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarEntityContext context = new CarEntityContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cl in context.Colors
                             on c.ColorId equals cl.ColorId
                             select new CarDetailDto
                             {
                                 CarName = c.CarName,
                                 DailyPrice = c.DailyPrice,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName
                             };
                return result.ToList();
            }
        }
    }
}
