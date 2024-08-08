using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.EntityLayer.Entities
{
    public class Approval
    {
        [Key]
        public int ApprovalID { get; set; }

        [Required]
        public int ExcVAT { get; set; }

        [Required]
        public int InVAT { get; set; }
        [Required]
        public int TotalAmount { get; set; }

    }
}
