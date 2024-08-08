using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.DtoLayer.SubLevelDto
{
    public class CreateSubLevelDto
    {
        public int SubLevelID { get; set; }

        public int SubLevelNo { get; set; }

        public string SubLevelDescription { get; set; }
    }
}
