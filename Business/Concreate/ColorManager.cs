using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
   public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            ValidationTool.Validation(new ColorValidator(), color);
            _colorDal.Add(color);

            return new Result(true, "Added color");

        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);

            return new Result(true, "Deleted color");
        }

        public IDataResult<List<Color>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),Messages.ColorsListed);
        }

        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(p => p.ColorId == colorId));
        }

        public IDataResult<List<Color>> GetColorByColorId(int id)
        {
           return new SuccessDataResult<List<Color>>(_colorDal.GetAll(p => p.ColorId == id));
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new Result(true, "Updated color");
        }
    }
}
