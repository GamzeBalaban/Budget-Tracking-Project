using BudgetTracking.BusinessLayer.Abstract;
using BudgetTracking.DataAccessLayer.Abstract;
using BudgetTracking.EntityLayer.Entities;
using System;
using System.Collections.Generic;

namespace BudgetTracking.BusinessLayer.Concrete
{
    public class BudgetAmountManager : IBudgetAmountService
    {
        private readonly IBudgetAmountDal _budgetAmountDal;

        public BudgetAmountManager(IBudgetAmountDal budgetAmountDal)
        {
            _budgetAmountDal = budgetAmountDal;
        }

        public void TAdd(BudgetAmount entity)
        {
            _budgetAmountDal.Add(entity);
        }

        public void TDelete(BudgetAmount entity)
        {
            _budgetAmountDal.Delete(entity);
        }

        public List<BudgetAmount> TGetAll()
        {
            return _budgetAmountDal.GetAll();
        }

        public BudgetAmount TGetByID(int id)
        {
            return _budgetAmountDal.GetByID(id);
        }

        public List<BudgetAmount> TGetListAll()
        {
            return _budgetAmountDal.GetAll();
        }

        public void TUpdate(BudgetAmount entity)
        {
            _budgetAmountDal.Update(entity);
        }

        object IBudgetAmountService.TGetListAll()
        {
            throw new NotImplementedException();
        }
    }
}
