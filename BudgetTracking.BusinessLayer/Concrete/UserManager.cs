using BudgetTracking.BusinessLayer.Abstract;
using BudgetTracking.DataAccessLayer.Abstract;
using BudgetTracking.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _addUserDal;

        public UserManager(IUserDal addUserDal)
        {
            _addUserDal = addUserDal;
        }

        public void TAdd(User entity)
        {
            _addUserDal.Add(entity);
        }

        public void TDelete(User entity)
        {
            _addUserDal.Delete(entity);
        }

        public List<User> TGetAll()
        {
            return _addUserDal.GetAll();
        }

        public User TGetByID(int id)
        {
            return _addUserDal.GetByID(id);
        }

        public void TUpdate(User entity)
        {
            _addUserDal.Update(entity);
        }
    }
}
