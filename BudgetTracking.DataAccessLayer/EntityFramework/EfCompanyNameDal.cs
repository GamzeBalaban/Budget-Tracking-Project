using BudgetTracking.DataAccessLayer.Abstract;
using BudgetTracking.DataAccessLayer.Concreate;
using BudgetTracking.DataAccessLayer.Repositories;
using BudgetTracking.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.DataAccessLayer.EntityFramework
{
    public class EfCompanyNameDal : GenericRepository<CompanyName>, ICompanyNameDal
    {
        public EfCompanyNameDal(BudgetContext context) : base(context)
        {
        }
    }
}
