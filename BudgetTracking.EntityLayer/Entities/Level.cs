using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.EntityLayer.Entities
{
    public class Level
    {
        [Key]
        public int LevelID { get; set; }

        [Required]
        public string LevelNo { get; set; }

    }
}
