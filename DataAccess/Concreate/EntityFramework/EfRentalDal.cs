using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concreate.EntityFramework
{
   public class EfRentalDal: EfEntityRepositoryBase<Rental, CarEntityContext>, IRentalDal
    {
        public void Add(Rental entity)
        {
            using (CarEntityContext context = new CarEntityContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Rental entity)
        {
            using (CarEntityContext context = new CarEntityContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Update(Rental entity)
        {
            using (CarEntityContext context = new CarEntityContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public Rental Get(Expression<Func<Rental, bool>> filter)
        {
            using (CarEntityContext context = new CarEntityContext())
            {
                return context.Set<Rental>().SingleOrDefault(filter);
            }
        }

        public List<Rental> GetAll(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarEntityContext context = new CarEntityContext())
            {
                return filter == null
                ? context.Set<Rental>().ToList()
                : context.Set<Rental>().Where(filter).ToList();
            }
        }

        

    }
}
