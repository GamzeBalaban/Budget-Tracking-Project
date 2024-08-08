using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.DtoLayer.PlanningDto
{
    public class ResultPlanningDto
    {
        public int PlanID { get; set; }

        public int ExcVAT { get; set; }

        public int InVAT { get; set; }


        public bool PayStatus { get; set; }
        public float UsableBudget { get; set; }

        public float AvailableBudget { get; set; }

        public float RemaningBudget { get; set; }

        public float TotalExpenditure { get; set; }


        public string Documents { get; set; }
    }
}
