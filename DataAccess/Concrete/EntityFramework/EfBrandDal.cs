using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, CarEntityContext>, IBrandDal
    {
        public void Add(Brand entity)
        {
            using (CarEntityContext context = new CarEntityContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Brand entity)
        {
            using (CarEntityContext context = new CarEntityContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Update(Brand entity)
        {
            using (CarEntityContext context = new CarEntityContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (CarEntityContext context = new CarEntityContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (CarEntityContext context = new CarEntityContext())
            {
                return filter == null
                ? context.Set<Brand>().ToList()
                : context.Set<Brand>().Where(filter).ToList();
        }
        }

        public List<Car> GetByIdCar(int carId)
        {
            throw new NotImplementedException();
        }

        List<Brand> IEntityRepository<Brand>.GetByIdCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
