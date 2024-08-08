using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.EntityLayer.Entities
{
    public class Realization
    {
        [Key]
        public int RealizationID { get; set; }
        [Required]
        public int TotalAmount { get; set; }

        [Required]
        public bool PayStatus { get; set; }

        [Required]
        public float UsableBudget { get; set; }

        [Required]
        public float RemainingBudget { get; set; }

        [Required]
        public float TotalExpenditure { get; set; }
        [Required]
        public int ExcVAT { get; set; }

        [Required]
        public int InVAT { get; set; }
    }
}
