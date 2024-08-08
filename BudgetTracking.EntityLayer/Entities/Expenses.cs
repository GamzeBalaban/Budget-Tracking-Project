using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.EntityLayer.Entities
{
    public class Expenses
    {

        [Key]
        public int ExpensesID { get; set; }
        [Required]
        [StringLength(50)]
        public string ExpensesType { get; set; }
      
    }
}
