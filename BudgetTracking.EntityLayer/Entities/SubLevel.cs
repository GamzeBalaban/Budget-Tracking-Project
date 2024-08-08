using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.EntityLayer.Entities
{
    public class SubLevel
    {
        [Key]
        public int SubLevelID { get; set; }

        [Required]
        public int SubLevelNo { get; set; }

        public string SubLevelDescription { get; set; }

    }
}
