using Entities.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get(Expression<Func<T, bool>> filter);
        List<Car> GetByIdCar(int carId);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
