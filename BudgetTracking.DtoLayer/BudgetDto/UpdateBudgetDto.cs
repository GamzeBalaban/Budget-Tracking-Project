using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.DtoLayer.BudgetDto
{
    public class UpdateBudgetDto
    {
        public int BudgetTypeID { get; set; }

        public string BudgetType { get; set; }
    }
}
