using BudgetTracking.BusinessLayer.Abstract;
using BudgetTracking.DataAccessLayer.Abstract;
using BudgetTracking.EntityLayer.Entities;
using ButceTracking.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.BusinessLayer.Concrete
{
    public class RefuseManager : IRefuseService
    {
        private readonly IRefuseDal _refuseDal;

        public RefuseManager(IRefuseDal refuseDal)
        {
            _refuseDal = refuseDal;
        }

        public void TAdd(Refuse entity)
        {
            _refuseDal.Add(entity);
        }

        public void TDelete(Refuse entity)
        {
            _refuseDal.Delete(entity);
        }


        public Refuse TGetByID(int id)
        {
           return  _refuseDal.GetByID(id);
        }

        public List<Refuse> TGetAll()
        {
            return _refuseDal.GetAll();
        }

        public void TUpdate(Refuse entity)
        {
            _refuseDal.Update(entity);
        }
    }
}
