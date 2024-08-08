using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.DtoLayer.ApprovalDto
{
    public class GetApprovalDto
    {
        public int ApprovalID { get; set; }

        public int ExcVAT { get; set; }

        
        public int InVAT { get; set; }
        public int TotalAmount { get; set; }
    }
}
