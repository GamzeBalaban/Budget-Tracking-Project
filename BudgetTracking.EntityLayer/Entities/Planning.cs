using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.EntityLayer.Entities
{
    public class Planning
    {
        [Key]
        public int PlanID { get; set; }

        [Required]
        public int ExcVAT { get; set; }

        [Required]
        public int InVAT { get; set; }

        [Required]
        public bool PayStatus { get; set; }
        [Required]
        public float UsableBudget { get; set; }

        [Required]
        public float AvailableBudget { get; set; }

        [Required]
        public float RemaningBudget { get; set; }

        [Required]
        public float TotalExpenditure { get; set; }


        [Required]
        [StringLength(50)]
        public string Documents { get; set; }
    }
}
