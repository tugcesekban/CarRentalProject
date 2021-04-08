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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            ValidationTool.Validation(new UserValidator(), user);
            _userDal.Add(user);
            return new Result(true, "Added an user");
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new Result(true, "Deleted an user"); 
        }

        public IDataResult<List<User>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<User>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UserListed);
        }

        public IDataResult<User> GetById(int userId)
        {
           return new SuccessDataResult<User>(_userDal.Get(p=>p.Id==userId));
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new Result(true, "Updated an user"); 
        }
    }
}
