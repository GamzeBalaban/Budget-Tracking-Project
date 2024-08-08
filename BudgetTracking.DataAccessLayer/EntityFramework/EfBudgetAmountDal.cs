using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetTracking.DataAccessLayer.Abstract;
using BudgetTracking.DataAccessLayer.Concreate;
using BudgetTracking.DataAccessLayer.Repositories;
using BudgetTracking.EntityLayer.Entities;

namespace BudgetTracking.DataAccessLayer.EntityFramework
{
    public class EfBudgetAmountDal : GenericRepository<BudgetAmount>, IBudgetAmountDal

    {
        public EfBudgetAmountDal(BudgetContext context) : base(context)
        {
        }
    }
}
