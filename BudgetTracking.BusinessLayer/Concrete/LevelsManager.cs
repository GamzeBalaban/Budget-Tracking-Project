using BudgetTracking.BusinessLayer.Abstract;
using BudgetTracking.DataAccessLayer.Abstract;
using BudgetTracking.DataAccessLayer.EntityFramework;
using BudgetTracking.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.BusinessLayer.Concrete
{
    public class LevelsManager : ILevelService
    {
        private readonly ILevelDal _levelsDal;

        public LevelsManager(ILevelDal levelsDal)
        {
            _levelsDal = levelsDal;
        }

        public void TAdd(Level entity)
        {
            _levelsDal.Add(entity);
        }

        public void TDelete(Level entity)
        {
            _levelsDal.Delete(entity);
        }

        public List<Level> TGetAll()
        {
            return _levelsDal.GetAll();
        }

        public Level TGetByID(int id)
        {
           return _levelsDal.GetByID(id);
        }

        public void TUpdate(Level entity)
        {
            _levelsDal.Update(entity);
        }
    }
}
