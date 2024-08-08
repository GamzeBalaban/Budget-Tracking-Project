using BudgetTracking.DataAccessLayer.Abstract;
using BudgetTracking.DataAccessLayer.Concreate;
using BudgetTracking.DataAccessLayer.Repositories;
using BudgetTracking.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButceTracking.DataAccessLayer.EntityFramework
{
    public class EfSubLevelDal : GenericRepository<SubLevel>, ISubLevelDal
    {
        public EfSubLevelDal(BudgetContext context) : base(context)
        {
        }
    }
}
