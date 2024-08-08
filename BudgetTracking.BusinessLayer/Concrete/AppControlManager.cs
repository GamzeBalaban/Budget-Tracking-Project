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
    public class AppControlManager : IAppControlService
    {
        private readonly IAppControlDal _appcontrolDal;

        public AppControlManager(IAppControlDal appcontrolDal)
        {
            _appcontrolDal = appcontrolDal;
        }

        public void TAdd(AppControl entity)
        {
            _appcontrolDal.Add(entity);
                
        }

        public void TDelete(AppControl entity)
        {
            _appcontrolDal.Delete(entity);
        }

        public List<AppControl> TGetAll()
        {
            return _appcontrolDal.GetAll();
        }

        public AppControl TGetByID(int id)
        {
            return _appcontrolDal.GetByID(id);
        }

        public void TUpdate(AppControl entity)
        {
            _appcontrolDal.Update(entity);
        }
    }
}
