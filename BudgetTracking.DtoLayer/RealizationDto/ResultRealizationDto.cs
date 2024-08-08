using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.DtoLayer.RealizationDto
{
    public class ResultRealizationDto
    {
        public int RealizationID { get; set; }
        public int TotalAmount { get; set; }

        public bool PayStatus { get; set; }

        public float UsableBudget { get; set; }

        public float RemainingBudget { get; set; }

        public float TotalExpenditure { get; set; }
        public int ExcVAT { get; set; }

        public int InVAT { get; set; }
    }
}
