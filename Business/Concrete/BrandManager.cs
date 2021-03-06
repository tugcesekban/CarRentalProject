using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class BrandManager:IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);

            return new Result(true, "Added the brand");
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new Result(true, "Deleted the brand");
        }

        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandsListed);
        }

        public IDataResult<List<Brand>> GetBrandByBrandId(int id)
        {
            return new SuccessDataResult<List<Brand>> (_brandDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(p => p.BrandId == brandId));
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new Result(true, "Updated the brand");
        }
    }
}
