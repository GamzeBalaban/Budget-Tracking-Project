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
    public class CompanyNameManager : ICompanyNameService
    {
        private readonly ICompanyNameDal _companyNameDal;

        public CompanyNameManager(ICompanyNameDal companyNameDal)
        {
            _companyNameDal = companyNameDal;
        }

        public void TAdd(CompanyName entity)
        {
            _companyNameDal.Add(entity);
        }

        public void TDelete(CompanyName entity)
        {
            _companyNameDal.Delete(entity);
        }

        public List<CompanyName> TGetAll()
        {
            return _companyNameDal.GetAll();
        }

        public CompanyName TGetByID(int id)
        {
            return _companyNameDal.GetByID(id);
        }

        public void TUpdate(CompanyName entity)
        {
            _companyNameDal.Update(entity);
        }
    }
}
