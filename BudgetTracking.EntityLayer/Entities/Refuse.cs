using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.EntityLayer.Entities
{
    public class Refuse
    {
        [Key]
        public int RefuseID { get; set; }

        [Required]
        [StringLength(50)]
        public string RefuseReason { get; set; }

    }
}
