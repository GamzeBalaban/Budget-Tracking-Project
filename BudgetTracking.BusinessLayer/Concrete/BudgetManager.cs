﻿using BudgetTracking.BusinessLayer.Abstract;
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
    public class BudgetManager : IBudgetService
    {

        private readonly IBudgetDal _budgetDal;

        public BudgetManager(IBudgetDal budgetDal)
        {
            _budgetDal = budgetDal;
        }

        public void TAdd(Budget entity)
        {
            _budgetDal.Add(entity);
        }

        public void TDelete(Budget entity)
        {
            _budgetDal.Delete(entity);
        }

        public List<Budget> TGetAll()
        {
            return _budgetDal.GetAll();
        }

        public Budget TGetByID(int id)
        {
            return _budgetDal.GetByID(id);
        }

        public void TUpdate(Budget entity)
        {
            _budgetDal.Update(entity);
        }
    }
}
