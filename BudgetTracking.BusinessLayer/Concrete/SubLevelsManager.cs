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
    public class SubLevelsManager : ISubLevelService

    {
        private readonly ISubLevelDal _subLevelsDal;

        public SubLevelsManager(ISubLevelDal subLevelsDal)
        {
            _subLevelsDal = subLevelsDal;
        }

        public void TAdd(SubLevel entity)
        {
            _subLevelsDal.Add(entity);
        }

        public void TDelete(SubLevel entity)
        {
            _subLevelsDal.Delete(entity);
        }

        public List<SubLevel> TGetAll()
        {
            return _subLevelsDal.GetAll();
        }

        public SubLevel TGetByID(int id)
        {
            return _subLevelsDal.GetByID(id);
        }

        public void TUpdate(SubLevel entity)
        {
           _subLevelsDal.Update(entity);
        }
    }
}
